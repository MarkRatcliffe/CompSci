namespace QueueExample
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
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.removeTextBox = new System.Windows.Forms.TextBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.queueDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(28, 27);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(141, 55);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(28, 110);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(141, 55);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(175, 45);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(100, 20);
            this.addTextBox.TabIndex = 2;
            // 
            // removeTextBox
            // 
            this.removeTextBox.Location = new System.Drawing.Point(175, 128);
            this.removeTextBox.Name = "removeTextBox";
            this.removeTextBox.Size = new System.Drawing.Size(100, 20);
            this.removeTextBox.TabIndex = 3;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(336, 203);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(61, 13);
            this.lengthLabel.TabIndex = 5;
            this.lengthLabel.Text = "Length  = 0";
            // 
            // queueDisplay
            // 
            this.queueDisplay.Location = new System.Drawing.Point(305, 12);
            this.queueDisplay.Multiline = true;
            this.queueDisplay.Name = "queueDisplay";
            this.queueDisplay.Size = new System.Drawing.Size(196, 173);
            this.queueDisplay.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 255);
            this.Controls.Add(this.queueDisplay);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.removeTextBox);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.TextBox removeTextBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox queueDisplay;
    }
}

