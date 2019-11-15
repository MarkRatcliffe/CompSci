namespace OneArmedBandit
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudgeButton1 = new System.Windows.Forms.Button();
            this.nudgeButton2 = new System.Windows.Forms.Button();
            this.nudgeButton3 = new System.Windows.Forms.Button();
            this.spinButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(306, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(104, 97);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(162, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 97);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nudgeButton1
            // 
            this.nudgeButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nudgeButton1.Location = new System.Drawing.Point(37, 175);
            this.nudgeButton1.Name = "nudgeButton1";
            this.nudgeButton1.Size = new System.Drawing.Size(75, 23);
            this.nudgeButton1.TabIndex = 3;
            this.nudgeButton1.Text = "Nudge";
            this.nudgeButton1.UseVisualStyleBackColor = false;
            this.nudgeButton1.Click += new System.EventHandler(this.nudgeButton1_Click);
            // 
            // nudgeButton2
            // 
            this.nudgeButton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nudgeButton2.Location = new System.Drawing.Point(174, 175);
            this.nudgeButton2.Name = "nudgeButton2";
            this.nudgeButton2.Size = new System.Drawing.Size(75, 23);
            this.nudgeButton2.TabIndex = 4;
            this.nudgeButton2.Text = "Nudge";
            this.nudgeButton2.UseVisualStyleBackColor = false;
            this.nudgeButton2.Click += new System.EventHandler(this.nudgeButton2_Click);
            // 
            // nudgeButton3
            // 
            this.nudgeButton3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nudgeButton3.Location = new System.Drawing.Point(319, 175);
            this.nudgeButton3.Name = "nudgeButton3";
            this.nudgeButton3.Size = new System.Drawing.Size(75, 23);
            this.nudgeButton3.TabIndex = 5;
            this.nudgeButton3.Text = "Nudge";
            this.nudgeButton3.UseVisualStyleBackColor = false;
            this.nudgeButton3.Click += new System.EventHandler(this.nudgeButton3_Click);
            // 
            // spinButton
            // 
            this.spinButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spinButton.Location = new System.Drawing.Point(141, 224);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(155, 50);
            this.spinButton.TabIndex = 6;
            this.spinButton.Text = "Spin";
            this.spinButton.UseVisualStyleBackColor = false;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 309);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.nudgeButton3);
            this.Controls.Add(this.nudgeButton2);
            this.Controls.Add(this.nudgeButton1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button nudgeButton1;
        private System.Windows.Forms.Button nudgeButton2;
        private System.Windows.Forms.Button nudgeButton3;
        private System.Windows.Forms.Button spinButton;
    }
}

