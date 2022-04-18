namespace SecurePasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.password = new System.Windows.Forms.TextBox();
            this.enableDisplay = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.useUnicode = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.useEmoji = new System.Windows.Forms.CheckBox();
            this.includedCharacters = new System.Windows.Forms.TextBox();
            this.useInclude = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.excludeCharacters = new System.Windows.Forms.TextBox();
            this.useExclude = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.useSymbols = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.useNumbers = new System.Windows.Forms.CheckBox();
            this.useLetters = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordLen = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLen)).BeginInit();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(8, 29);
            this.password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password.Name = "password";
            this.password.PlaceholderText = "No password generation is possible...";
            this.password.ReadOnly = true;
            this.password.Size = new System.Drawing.Size(207, 27);
            this.password.TabIndex = 0;
            this.password.UseSystemPasswordChar = true;
            // 
            // enableDisplay
            // 
            this.enableDisplay.AutoSize = true;
            this.enableDisplay.Location = new System.Drawing.Point(8, 69);
            this.enableDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enableDisplay.Name = "enableDisplay";
            this.enableDisplay.Size = new System.Drawing.Size(145, 24);
            this.enableDisplay.TabIndex = 1;
            this.enableDisplay.Text = "&Display Password";
            this.enableDisplay.UseVisualStyleBackColor = true;
            this.enableDisplay.CheckStateChanged += new System.EventHandler(this.DisplayPassword_CheckStateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.generate);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.enableDisplay);
            this.groupBox1.Location = new System.Drawing.Point(16, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(256, 156);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 103);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Copy_Click);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(116, 103);
            this.generate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(100, 35);
            this.generate.TabIndex = 3;
            this.generate.Text = "&Regenerate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.useUnicode);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.useEmoji);
            this.groupBox2.Controls.Add(this.includedCharacters);
            this.groupBox2.Controls.Add(this.useInclude);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.excludeCharacters);
            this.groupBox2.Controls.Add(this.useExclude);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.useSymbols);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.useNumbers);
            this.groupBox2.Controls.Add(this.useLetters);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.passwordLen);
            this.groupBox2.Location = new System.Drawing.Point(16, 185);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(256, 330);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 171);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Unicode Madness:";
            this.toolTip1.SetToolTip(this.label8, "No right, no wrong, no rules for me - I\'m free!");
            // 
            // useUnicode
            // 
            this.useUnicode.AutoSize = true;
            this.useUnicode.Location = new System.Drawing.Point(139, 171);
            this.useUnicode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.useUnicode.Name = "useUnicode";
            this.useUnicode.Size = new System.Drawing.Size(18, 17);
            this.useUnicode.TabIndex = 9;
            this.useUnicode.UseVisualStyleBackColor = true;
            this.useUnicode.CheckedChanged += new System.EventHandler(this.UseUnicodeMadness_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Emoji:";
            this.toolTip1.SetToolTip(this.label7, "No right, no wrong, no rules for me - I\'m free!");
            // 
            // useEmoji
            // 
            this.useEmoji.AutoSize = true;
            this.useEmoji.Location = new System.Drawing.Point(139, 144);
            this.useEmoji.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.useEmoji.Name = "useEmoji";
            this.useEmoji.Size = new System.Drawing.Size(18, 17);
            this.useEmoji.TabIndex = 8;
            this.toolTip1.SetToolTip(this.useEmoji, "No right, no wrong, no rules for me - I\'m free!");
            this.useEmoji.UseVisualStyleBackColor = true;
            // 
            // includedCharacters
            // 
            this.includedCharacters.Enabled = false;
            this.includedCharacters.Location = new System.Drawing.Point(10, 289);
            this.includedCharacters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.includedCharacters.Name = "includedCharacters";
            this.includedCharacters.ReadOnly = true;
            this.includedCharacters.Size = new System.Drawing.Size(203, 27);
            this.includedCharacters.TabIndex = 13;
            // 
            // useInclude
            // 
            this.useInclude.AutoSize = true;
            this.useInclude.Location = new System.Drawing.Point(139, 262);
            this.useInclude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.useInclude.Name = "useInclude";
            this.useInclude.Size = new System.Drawing.Size(18, 17);
            this.useInclude.TabIndex = 12;
            this.useInclude.UseVisualStyleBackColor = true;
            this.useInclude.CheckedChanged += new System.EventHandler(this.UseInclude_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Include:";
            // 
            // excludeCharacters
            // 
            this.excludeCharacters.Location = new System.Drawing.Point(10, 225);
            this.excludeCharacters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.excludeCharacters.Name = "excludeCharacters";
            this.excludeCharacters.Size = new System.Drawing.Size(203, 27);
            this.excludeCharacters.TabIndex = 11;
            this.excludeCharacters.Text = "0o";
            // 
            // useExclude
            // 
            this.useExclude.AutoSize = true;
            this.useExclude.Checked = true;
            this.useExclude.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useExclude.Location = new System.Drawing.Point(139, 198);
            this.useExclude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.useExclude.Name = "useExclude";
            this.useExclude.Size = new System.Drawing.Size(18, 17);
            this.useExclude.TabIndex = 10;
            this.useExclude.UseVisualStyleBackColor = true;
            this.useExclude.CheckedChanged += new System.EventHandler(this.UseExclude_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Exclude:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Symbols:";
            // 
            // useSymbols
            // 
            this.useSymbols.AutoSize = true;
            this.useSymbols.Checked = true;
            this.useSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useSymbols.Location = new System.Drawing.Point(139, 117);
            this.useSymbols.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.useSymbols.Name = "useSymbols";
            this.useSymbols.Size = new System.Drawing.Size(18, 17);
            this.useSymbols.TabIndex = 7;
            this.useSymbols.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numbers:";
            // 
            // useNumbers
            // 
            this.useNumbers.AutoSize = true;
            this.useNumbers.Checked = true;
            this.useNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useNumbers.Location = new System.Drawing.Point(139, 90);
            this.useNumbers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.useNumbers.Name = "useNumbers";
            this.useNumbers.Size = new System.Drawing.Size(18, 17);
            this.useNumbers.TabIndex = 6;
            this.useNumbers.UseVisualStyleBackColor = true;
            // 
            // useLetters
            // 
            this.useLetters.AutoSize = true;
            this.useLetters.Checked = true;
            this.useLetters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useLetters.Location = new System.Drawing.Point(139, 63);
            this.useLetters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.useLetters.Name = "useLetters";
            this.useLetters.Size = new System.Drawing.Size(18, 17);
            this.useLetters.TabIndex = 5;
            this.useLetters.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Letters:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password Length:";
            // 
            // passwordLen
            // 
            this.passwordLen.Location = new System.Drawing.Point(139, 26);
            this.passwordLen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordLen.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.passwordLen.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.passwordLen.Name = "passwordLen";
            this.passwordLen.Size = new System.Drawing.Size(53, 27);
            this.passwordLen.TabIndex = 4;
            this.passwordLen.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.passwordLen.ValueChanged += new System.EventHandler(this.PasswordLength_ValueChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Secure Password Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox enableDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown passwordLen;
        private System.Windows.Forms.CheckBox useLetters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox useNumbers;
        private System.Windows.Forms.CheckBox useSymbols;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox useExclude;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox excludeCharacters;
        private System.Windows.Forms.TextBox includedCharacters;
        private System.Windows.Forms.CheckBox useInclude;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox useEmoji;
        private System.Windows.Forms.ToolTip toolTip1;
        private Label label8;
        private CheckBox useUnicode;
    }
}

