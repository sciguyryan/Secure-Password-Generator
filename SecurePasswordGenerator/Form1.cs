using System.Security.Cryptography;

namespace SecurePasswordGenerator
{
    public partial class Form1 : Form
    {
        private readonly RandomNumberGenerator RNGCrypto = RandomNumberGenerator.Create();
        private readonly ViableCodePoints CodePoints = new();

        public Form1()
        {
            InitializeComponent();

            AcceptButton = generate;
            Icon = Utils.GetApplicationIcon();

            // Automatically apply an event handler for each checkbox to
            // generate a new password immediately upon check state changed.
            foreach (var c in groupBox2.Controls)
            {
                if (c is CheckBox check)
                {
                    check.CheckedChanged += (sender, e) => GeneratePassword();
                }
            }

            // Configure the various control tooltips.
            toolTip1.SetToolTip(passwordLen, "The length of the password to generate, in characters (or graphemes, if unicode or emoji are used)");
            toolTip1.SetToolTip(useLetters, "Use basic letters (a-z and A-Z)");
            toolTip1.SetToolTip(useNumbers, "Use basic numbers (0-9)");
            toolTip1.SetToolTip(useSymbols, "Use commonly accepted symbols");
            toolTip1.SetToolTip(useEmoji, "Use Emoji, ever permitted variant");
            toolTip1.SetToolTip(useUnicode, "No right, no wrong, no rules for me - I'm free!");
            toolTip1.SetToolTip(excludeCharacters, "Excluce specific characters from the password generation list");
            toolTip1.SetToolTip(includedCharacters, "Include specific characters in the password generation list");

            GeneratePassword();
        }

        public void GeneratePassword()
        {
            var codePoints = "";

            var isUnicode = useUnicode.Checked;
            var isEmoji = useEmoji.Checked;

            if (useLetters.Checked && !isUnicode)
            {
                codePoints += CodePoints.Letters;
            }

            if (useNumbers.Checked && !isUnicode)
            {
                codePoints += CodePoints.Numbers;
            }

            if (useSymbols.Checked && !isUnicode)
            {
                codePoints += CodePoints.Symbols;
            }

            if (isEmoji)
            {
                codePoints += CodePoints.Emoji;
            }

            if (isUnicode)
            {
                codePoints += CodePoints.Unicode;
            }

            if (useExclude.Checked)
            {
                foreach (var c in excludeCharacters.Text)
                {
                    codePoints = codePoints.Replace($"{c}", "");
                }
            }

            if (useInclude.Checked)
            {
                codePoints += includedCharacters.Text;
            }

            // Ensure that there is only one of each codepoint in our final string.
            // We do not want to do this when dealing with unicode since it slows
            // things down due to the vast number of codepoints available.
            var cpList = isUnicode ?
                codePoints.GetCodePoints() : codePoints.DeduplicateCodePoints();
            if (cpList.Length == 0)
            {
                password.Text = "";
                return;
            }

            var passwordText = "";
            var reminingCodePoints = (int)passwordLen.Value;
            while (reminingCodePoints > 0)
            {
                passwordText += cpList[CryptoRandomInteger(0, cpList.Length)];
                --reminingCodePoints;
            }

            password.Text = passwordText;
        }

        private int CryptoRandomInteger(int min, int max)
        {
            var scale = uint.MaxValue;
            while (scale == uint.MaxValue)
            {
                var fourBytes = new byte[4];
                RNGCrypto.GetBytes(fourBytes);

                scale = BitConverter.ToUInt32(fourBytes, 0);
            }

            return (int)(min + (max - min) * (scale / (double)uint.MaxValue));
        }

        private void DisplayPassword_CheckStateChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = !enableDisplay.Checked;
        }

        private void PasswordLength_ValueChanged(object sender, EventArgs e)
        {
            GeneratePassword();
        }

        private void UseExclude_CheckedChanged(object sender, EventArgs e)
        {
            excludeCharacters.Enabled = useExclude.Checked;
            excludeCharacters.ReadOnly = !useExclude.Checked;
        }

        private void UseInclude_CheckedChanged(object sender, EventArgs e)
        {
            includedCharacters.Enabled = useInclude.Checked;
            includedCharacters.ReadOnly = !useInclude.Checked;
        }

        private void UseUnicodeMadness_CheckedChanged(object sender, EventArgs e)
        {
            var controls = new [] { useLetters, useNumbers, useSymbols };
            foreach (var c in controls)
            {
                c.Enabled = !useUnicode.Checked;
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            GeneratePassword();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(password.Text);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.D | Keys.Control | Keys.Shift))
            {
                using var f = new Form2();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // We need to update the codepoint list.
                    CodePoints.ReadCacheFile();

                    // Generate a new password based on the updated defaults.
                    GeneratePassword();
                }

                return true;
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
