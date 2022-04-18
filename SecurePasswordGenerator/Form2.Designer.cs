namespace SecurePasswordGenerator
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateEmoji = new System.Windows.Forms.CheckBox();
            this.updateUnicode = new System.Windows.Forms.CheckBox();
            this.save = new System.Windows.Forms.Button();
            this.symbols = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numbers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.letters = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateEmoji);
            this.groupBox1.Controls.Add(this.updateUnicode);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.symbols);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numbers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.letters);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Default Configuration";
            // 
            // updateEmoji
            // 
            this.updateEmoji.AutoSize = true;
            this.updateEmoji.Checked = true;
            this.updateEmoji.CheckState = System.Windows.Forms.CheckState.Checked;
            this.updateEmoji.Location = new System.Drawing.Point(10, 155);
            this.updateEmoji.Name = "updateEmoji";
            this.updateEmoji.Size = new System.Drawing.Size(122, 24);
            this.updateEmoji.TabIndex = 5;
            this.updateEmoji.Text = "Update &Emoji";
            this.updateEmoji.UseVisualStyleBackColor = true;
            // 
            // updateUnicode
            // 
            this.updateUnicode.AutoSize = true;
            this.updateUnicode.Checked = true;
            this.updateUnicode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.updateUnicode.Location = new System.Drawing.Point(10, 125);
            this.updateUnicode.Name = "updateUnicode";
            this.updateUnicode.Size = new System.Drawing.Size(139, 24);
            this.updateUnicode.TabIndex = 4;
            this.updateUnicode.Text = "Update &Unicode";
            this.updateUnicode.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(6, 185);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(94, 29);
            this.save.TabIndex = 6;
            this.save.Text = "&Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // symbols
            // 
            this.symbols.Location = new System.Drawing.Point(84, 92);
            this.symbols.Name = "symbols";
            this.symbols.Size = new System.Drawing.Size(487, 27);
            this.symbols.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Symbols:";
            // 
            // numbers
            // 
            this.numbers.Location = new System.Drawing.Point(84, 59);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(487, 27);
            this.numbers.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numbers:";
            // 
            // letters
            // 
            this.letters.Location = new System.Drawing.Point(84, 26);
            this.letters.Name = "letters";
            this.letters.Size = new System.Drawing.Size(487, 27);
            this.letters.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Letters:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 252);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Configuration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox symbols;
        private Label label4;
        private TextBox numbers;
        private Label label2;
        private TextBox letters;
        private Label label1;
        private Button save;
        private CheckBox updateEmoji;
        private CheckBox updateUnicode;
    }
}