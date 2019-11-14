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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.useUnicodeMadness = new System.Windows.Forms.CheckBox();
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
            this.password.Location = new System.Drawing.Point(8, 23);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Size = new System.Drawing.Size(207, 22);
            this.password.TabIndex = 0;
            this.password.UseSystemPasswordChar = true;
            // 
            // enableDisplay
            // 
            this.enableDisplay.AutoSize = true;
            this.enableDisplay.Location = new System.Drawing.Point(8, 55);
            this.enableDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.enableDisplay.Name = "enableDisplay";
            this.enableDisplay.Size = new System.Drawing.Size(141, 21);
            this.enableDisplay.TabIndex = 1;
            this.enableDisplay.Text = "&Display Password";
            this.enableDisplay.UseVisualStyleBackColor = true;
            this.enableDisplay.CheckStateChanged += new System.EventHandler(this.CheckBox1_CheckStateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.enableDisplay);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(256, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 84);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Regenerate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.useUnicodeMadness);
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
            this.groupBox2.Location = new System.Drawing.Point(16, 148);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(256, 270);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Unicode Madness:";
            this.toolTip1.SetToolTip(this.label7, "No right, no wrong, no rules for me - I\'m free!");
            // 
            // useUnicodeMadness
            // 
            this.useUnicodeMadness.AutoSize = true;
            this.useUnicodeMadness.Location = new System.Drawing.Point(139, 127);
            this.useUnicodeMadness.Margin = new System.Windows.Forms.Padding(4);
            this.useUnicodeMadness.Name = "useUnicodeMadness";
            this.useUnicodeMadness.Size = new System.Drawing.Size(18, 17);
            this.useUnicodeMadness.TabIndex = 7;
            this.toolTip1.SetToolTip(this.useUnicodeMadness, "No right, no wrong, no rules for me - I\'m free!");
            this.useUnicodeMadness.UseVisualStyleBackColor = true;
            this.useUnicodeMadness.CheckedChanged += new System.EventHandler(this.UseUnicodeMadness_CheckedChanged);
            // 
            // includedCharacters
            // 
            this.includedCharacters.Enabled = false;
            this.includedCharacters.Location = new System.Drawing.Point(10, 232);
            this.includedCharacters.Margin = new System.Windows.Forms.Padding(4);
            this.includedCharacters.Name = "includedCharacters";
            this.includedCharacters.ReadOnly = true;
            this.includedCharacters.Size = new System.Drawing.Size(203, 22);
            this.includedCharacters.TabIndex = 11;
            // 
            // useInclude
            // 
            this.useInclude.AutoSize = true;
            this.useInclude.Location = new System.Drawing.Point(139, 207);
            this.useInclude.Margin = new System.Windows.Forms.Padding(4);
            this.useInclude.Name = "useInclude";
            this.useInclude.Size = new System.Drawing.Size(18, 17);
            this.useInclude.TabIndex = 10;
            this.useInclude.UseVisualStyleBackColor = true;
            this.useInclude.CheckedChanged += new System.EventHandler(this.UseInclude_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Include:";
            // 
            // excludeCharacters
            // 
            this.excludeCharacters.Location = new System.Drawing.Point(11, 177);
            this.excludeCharacters.Margin = new System.Windows.Forms.Padding(4);
            this.excludeCharacters.Name = "excludeCharacters";
            this.excludeCharacters.Size = new System.Drawing.Size(203, 22);
            this.excludeCharacters.TabIndex = 9;
            this.excludeCharacters.Text = "0o";
            // 
            // useExclude
            // 
            this.useExclude.AutoSize = true;
            this.useExclude.Checked = true;
            this.useExclude.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useExclude.Location = new System.Drawing.Point(139, 152);
            this.useExclude.Margin = new System.Windows.Forms.Padding(4);
            this.useExclude.Name = "useExclude";
            this.useExclude.Size = new System.Drawing.Size(18, 17);
            this.useExclude.TabIndex = 8;
            this.useExclude.UseVisualStyleBackColor = true;
            this.useExclude.CheckedChanged += new System.EventHandler(this.UseExclude_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Exclude:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Symbols:";
            // 
            // useSymbols
            // 
            this.useSymbols.AutoSize = true;
            this.useSymbols.Checked = true;
            this.useSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useSymbols.Location = new System.Drawing.Point(139, 102);
            this.useSymbols.Margin = new System.Windows.Forms.Padding(4);
            this.useSymbols.Name = "useSymbols";
            this.useSymbols.Size = new System.Drawing.Size(18, 17);
            this.useSymbols.TabIndex = 6;
            this.useSymbols.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numbers:";
            // 
            // useNumbers
            // 
            this.useNumbers.AutoSize = true;
            this.useNumbers.Checked = true;
            this.useNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useNumbers.Location = new System.Drawing.Point(139, 78);
            this.useNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.useNumbers.Name = "useNumbers";
            this.useNumbers.Size = new System.Drawing.Size(18, 17);
            this.useNumbers.TabIndex = 5;
            this.useNumbers.UseVisualStyleBackColor = true;
            // 
            // useLetters
            // 
            this.useLetters.AutoSize = true;
            this.useLetters.Checked = true;
            this.useLetters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useLetters.Location = new System.Drawing.Point(139, 54);
            this.useLetters.Margin = new System.Windows.Forms.Padding(4);
            this.useLetters.Name = "useLetters";
            this.useLetters.Size = new System.Drawing.Size(18, 17);
            this.useLetters.TabIndex = 5;
            this.useLetters.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Letters:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password Length:";
            // 
            // passwordLen
            // 
            this.passwordLen.Location = new System.Drawing.Point(139, 21);
            this.passwordLen.Margin = new System.Windows.Forms.Padding(4);
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
            this.passwordLen.Size = new System.Drawing.Size(53, 22);
            this.passwordLen.TabIndex = 4;
            this.passwordLen.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.passwordLen.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.CheckBox useUnicodeMadness;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

