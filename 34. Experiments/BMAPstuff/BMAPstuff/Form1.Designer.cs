namespace BMAPstuff
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
            this.mainDisplay = new System.Windows.Forms.PictureBox();
            this.miniDisplay = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colourBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDisplay
            // 
            this.mainDisplay.Location = new System.Drawing.Point(164, 12);
            this.mainDisplay.Name = "mainDisplay";
            this.mainDisplay.Size = new System.Drawing.Size(333, 281);
            this.mainDisplay.TabIndex = 0;
            this.mainDisplay.TabStop = false;
            // 
            // miniDisplay
            // 
            this.miniDisplay.Location = new System.Drawing.Point(269, 319);
            this.miniDisplay.Name = "miniDisplay";
            this.miniDisplay.Size = new System.Drawing.Size(107, 90);
            this.miniDisplay.TabIndex = 1;
            this.miniDisplay.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Main Display";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mini Display";
            // 
            // colourBox
            // 
            this.colourBox.Location = new System.Drawing.Point(423, 352);
            this.colourBox.Name = "colourBox";
            this.colourBox.Size = new System.Drawing.Size(207, 20);
            this.colourBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Colour over Mouse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colourBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.miniDisplay);
            this.Controls.Add(this.mainDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainDisplay;
        private System.Windows.Forms.PictureBox miniDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox colourBox;
        private System.Windows.Forms.Label label3;
    }
}

