using System;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Linq;
using System.Reflection;
using System.Diagnostics;

namespace SecurePasswordGenerator
{
    public partial class Form1 : Form
    {
        private readonly RNGCryptoServiceProvider RNGCrypto = new RNGCryptoServiceProvider();

        public Form1()
        {
            this.Icon = this.GetApplicationIcon();

            InitializeComponent();

            this.AcceptButton = this.button1;

            // Automatically apply an event handler for each
            // checkbox to generate a new password
            // immediately upon check state changed.
            foreach (Control c in this.groupBox2.Controls)
            {
                if (c is CheckBox check)
                {
                    check.CheckedChanged += (sender, e) => this.GeneratePassword();
                }
            }

            this.GeneratePassword();
        }

        ~Form1()
        {
            this.RNGCrypto.Dispose();
        }

        public void GeneratePassword()
        {
            var reminingChars = (int)this.passwordLen.Value;
            var finalPassword = "";
            var availableChars = "";
            var availableFinal = "";

            // This case is special and requires a bit more ground work.
            if (this.useUnicodeMadness.Checked)
            {
                availableFinal = ViableCharacters.Unicode;
            }
            else
            {
                if (this.useLetters.Checked)
                {
                    availableChars += ViableCharacters.Letters;
                }

                if (this.useNumbers.Checked)
                {
                    availableChars += ViableCharacters.Numbers;
                }

                if (this.useSymbols.Checked)
                {
                    availableChars += ViableCharacters.Symbols;
                }

                if (this.useExclude.Checked)
                {
                    foreach (char c in this.excludeCharacters.Text)
                    {
                        availableChars = availableChars.Replace(c.ToString(), "");
                    }
                }

                if (this.useInclude.Checked)
                {
                    availableChars += this.includedCharacters.Text;
                }

                // De-duplicate the characters.
                availableFinal = new string(availableChars.Distinct().ToArray());
            }

            var availableLen = (availableFinal.Length - 1);
            if (availableLen == -1)
            {
                return;
            }

            while (reminingChars > 0)
            {
                finalPassword += availableFinal[this.CryptoRandomInteger(0, availableLen)];
                --reminingChars;
            }

            this.password.Text = finalPassword;
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

        private void CheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
            this.password.UseSystemPasswordChar = !this.enableDisplay.Checked;
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.GeneratePassword();
        }

        private void UseExclude_CheckedChanged(object sender, EventArgs e)
        {
            this.excludeCharacters.Enabled = this.useExclude.Checked;
            this.excludeCharacters.ReadOnly = !this.useExclude.Checked;

            this.GeneratePassword();
        }

        private void UseInclude_CheckedChanged(object sender, EventArgs e)
        {
            this.includedCharacters.Enabled = this.useInclude.Checked;
            this.includedCharacters.ReadOnly = !this.useInclude.Checked;

            this.GeneratePassword();
        }

        private void UseUnicodeMadness_CheckedChanged(object sender, EventArgs e)
        {
            var enable = !this.useUnicodeMadness.Checked;

            this.useInclude.Enabled = enable;
            this.includedCharacters.Enabled = enable;
            this.useExclude.Enabled = enable;
            this.excludeCharacters.Enabled = enable;
            this.useLetters.Enabled = enable;
            this.useNumbers.Enabled = enable;
            this.useSymbols.Enabled = enable;

            this.GeneratePassword();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.GeneratePassword();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.password.Text);
        }

        private Icon GetApplicationIcon()
        {
            return Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
        }
    }
}
