namespace StackUI
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
            this.pushButton = new System.Windows.Forms.Button();
            this.popButton = new System.Windows.Forms.Button();
            this.stackDisplay = new System.Windows.Forms.TextBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.dataEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pushButton
            // 
            this.pushButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.pushButton.Location = new System.Drawing.Point(31, 90);
            this.pushButton.Name = "pushButton";
            this.pushButton.Size = new System.Drawing.Size(75, 23);
            this.pushButton.TabIndex = 0;
            this.pushButton.Text = "Push";
            this.pushButton.UseVisualStyleBackColor = false;
            this.pushButton.Click += new System.EventHandler(this.pushButton_Click);
            // 
            // popButton
            // 
            this.popButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.popButton.Location = new System.Drawing.Point(31, 143);
            this.popButton.Name = "popButton";
            this.popButton.Size = new System.Drawing.Size(75, 23);
            this.popButton.TabIndex = 1;
            this.popButton.Text = "Pop";
            this.popButton.UseVisualStyleBackColor = false;
            this.popButton.Click += new System.EventHandler(this.popButton_Click);
            // 
            // stackDisplay
            // 
            this.stackDisplay.Enabled = false;
            this.stackDisplay.Location = new System.Drawing.Point(242, 80);
            this.stackDisplay.Multiline = true;
            this.stackDisplay.Name = "stackDisplay";
            this.stackDisplay.Size = new System.Drawing.Size(83, 175);
            this.stackDisplay.TabIndex = 3;
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(257, 270);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(48, 15);
            this.topLabel.TabIndex = 4;
            this.topLabel.Text = "Top = 0";
            // 
            // dataEntry
            // 
            this.dataEntry.Location = new System.Drawing.Point(122, 119);
            this.dataEntry.Name = "dataEntry";
            this.dataEntry.Size = new System.Drawing.Size(100, 20);
            this.dataEntry.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Stack Demo ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(381, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataEntry);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.stackDisplay);
            this.Controls.Add(this.popButton);
            this.Controls.Add(this.pushButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pushButton;
        private System.Windows.Forms.Button popButton;
        private System.Windows.Forms.TextBox stackDisplay;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.TextBox dataEntry;
        private System.Windows.Forms.Label label1;
    }
}

