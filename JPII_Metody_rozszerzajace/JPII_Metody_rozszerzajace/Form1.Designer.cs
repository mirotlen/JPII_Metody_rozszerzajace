namespace JPII_Metody_rozszerzajace
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.but_2char_Uppercase = new System.Windows.Forms.Button();
            this.but_1char_Uppercase = new System.Windows.Forms.Button();
            this.but_removeVolwes = new System.Windows.Forms.Button();
            this.but_wordCounter = new System.Windows.Forms.Button();
            this.but_letterCounter = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox_input.Location = new System.Drawing.Point(36, 46);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(259, 20);
            this.textBox_input.TabIndex = 0;
            this.textBox_input.Text = "Enter smth here";
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(36, 91);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(259, 116);
            this.textBox_output.TabIndex = 1;
            // 
            // but_2char_Uppercase
            // 
            this.but_2char_Uppercase.Location = new System.Drawing.Point(323, 46);
            this.but_2char_Uppercase.Name = "but_2char_Uppercase";
            this.but_2char_Uppercase.Size = new System.Drawing.Size(120, 41);
            this.but_2char_Uppercase.TabIndex = 2;
            this.but_2char_Uppercase.Text = "AlA mA kOtA";
            this.but_2char_Uppercase.UseVisualStyleBackColor = true;
            this.but_2char_Uppercase.Click += new System.EventHandler(this.but_2char_Uppercase_Click);
            // 
            // but_1char_Uppercase
            // 
            this.but_1char_Uppercase.Location = new System.Drawing.Point(323, 93);
            this.but_1char_Uppercase.Name = "but_1char_Uppercase";
            this.but_1char_Uppercase.Size = new System.Drawing.Size(120, 41);
            this.but_1char_Uppercase.TabIndex = 3;
            this.but_1char_Uppercase.Text = "Ala Ma Kota";
            this.but_1char_Uppercase.UseVisualStyleBackColor = true;
            this.but_1char_Uppercase.Click += new System.EventHandler(this.but_1char_Uppercase_Click);
            // 
            // but_removeVolwes
            // 
            this.but_removeVolwes.Location = new System.Drawing.Point(323, 140);
            this.but_removeVolwes.Name = "but_removeVolwes";
            this.but_removeVolwes.Size = new System.Drawing.Size(120, 41);
            this.but_removeVolwes.TabIndex = 4;
            this.but_removeVolwes.Text = "l m kt";
            this.but_removeVolwes.UseVisualStyleBackColor = true;
            this.but_removeVolwes.Click += new System.EventHandler(this.but_removeVolwes_Click);
            // 
            // but_wordCounter
            // 
            this.but_wordCounter.Location = new System.Drawing.Point(323, 187);
            this.but_wordCounter.Name = "but_wordCounter";
            this.but_wordCounter.Size = new System.Drawing.Size(120, 41);
            this.but_wordCounter.TabIndex = 5;
            this.but_wordCounter.Text = "Ala ma kota = 3";
            this.but_wordCounter.UseVisualStyleBackColor = true;
            this.but_wordCounter.Click += new System.EventHandler(this.but_wordCounter_Click);
            // 
            // but_letterCounter
            // 
            this.but_letterCounter.Location = new System.Drawing.Point(323, 234);
            this.but_letterCounter.Name = "but_letterCounter";
            this.but_letterCounter.Size = new System.Drawing.Size(120, 41);
            this.but_letterCounter.TabIndex = 6;
            this.but_letterCounter.Text = "[Ala - 3] [ma -2] [kota -4]";
            this.but_letterCounter.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(449, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 41);
            this.button6.TabIndex = 7;
            this.button6.Text = "Ala ma kota. - zdanie = true";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(449, 93);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(131, 41);
            this.button7.TabIndex = 8;
            this.button7.Text = "Ala ma kota (a - 4 powtórzenia)";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(449, 140);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(131, 41);
            this.button8.TabIndex = 9;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(449, 187);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(131, 41);
            this.button9.TabIndex = 10;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 300);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.but_letterCounter);
            this.Controls.Add(this.but_wordCounter);
            this.Controls.Add(this.but_removeVolwes);
            this.Controls.Add(this.but_1char_Uppercase);
            this.Controls.Add(this.but_2char_Uppercase);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.textBox_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Button but_2char_Uppercase;
        private System.Windows.Forms.Button but_1char_Uppercase;
        private System.Windows.Forms.Button but_removeVolwes;
        private System.Windows.Forms.Button but_wordCounter;
        private System.Windows.Forms.Button but_letterCounter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }

}

