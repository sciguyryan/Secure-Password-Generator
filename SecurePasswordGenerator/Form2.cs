namespace SecurePasswordGenerator
{
    public partial class Form2 : Form
    {
        private readonly ViableCodePoints CodePoints = new();

        public Form2()
        {
            InitializeComponent();

            letters.Text = CodePoints.Letters;
            numbers.Text = CodePoints.Numbers;
            symbols.Text = CodePoints.Symbols;

            AcceptButton = save;
            Icon = Utils.GetApplicationIcon();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            CodePoints.Letters = letters.Text;
            CodePoints.Numbers = numbers.Text;
            CodePoints.Symbols = symbols.Text;

            if (updateUnicode.Checked)
            {
                CodePoints.UpdateUnicodeCodePoints();
            }

            if (updateEmoji.Checked)
            {
                CodePoints.UpdateEmojiCodePoints();
            }

            CodePoints.WriteCacheFile();

            // Indicate that we have update the codepoint list.
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
