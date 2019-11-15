namespace HangmanGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resetbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentWordLabel = new System.Windows.Forms.Label();
            this.lettersUsedLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.letterInputBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hangman ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(164, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 168);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // resetbutton
            // 
            this.resetbutton.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbutton.Location = new System.Drawing.Point(14, 91);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(93, 34);
            this.resetbutton.TabIndex = 2;
            this.resetbutton.Text = "start";
            this.resetbutton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current Word";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Used Letters";
            // 
            // currentWordLabel
            // 
            this.currentWordLabel.AutoSize = true;
            this.currentWordLabel.Location = new System.Drawing.Point(14, 171);
            this.currentWordLabel.Name = "currentWordLabel";
            this.currentWordLabel.Size = new System.Drawing.Size(25, 13);
            this.currentWordLabel.TabIndex = 5;
            this.currentWordLabel.Text = "  ?  ";
            // 
            // lettersUsedLabel
            // 
            this.lettersUsedLabel.AutoSize = true;
            this.lettersUsedLabel.Location = new System.Drawing.Point(13, 223);
            this.lettersUsedLabel.Name = "lettersUsedLabel";
            this.lettersUsedLabel.Size = new System.Drawing.Size(28, 13);
            this.lettersUsedLabel.TabIndex = 6;
            this.lettersUsedLabel.Text = " _ _ ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Matura MT Script Capitals", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Choose your letter";
            // 
            // letterInputBox
            // 
            this.letterInputBox.Location = new System.Drawing.Point(164, 254);
            this.letterInputBox.Name = "letterInputBox";
            this.letterInputBox.Size = new System.Drawing.Size(100, 20);
            this.letterInputBox.TabIndex = 8;
            this.letterInputBox.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 303);
            this.Controls.Add(this.letterInputBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lettersUsedLabel);
            this.Controls.Add(this.currentWordLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currentWordLabel;
        private System.Windows.Forms.Label lettersUsedLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox letterInputBox;
    }
}

