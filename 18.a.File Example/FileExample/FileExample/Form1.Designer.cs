namespace FileExample
{
    partial class FileHandler
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
            this.loadButton = new System.Windows.Forms.Button();
            this.namesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(42, 75);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // namesTextBox
            // 
            this.namesTextBox.Location = new System.Drawing.Point(180, 73);
            this.namesTextBox.Multiline = true;
            this.namesTextBox.Name = "namesTextBox";
            this.namesTextBox.Size = new System.Drawing.Size(126, 253);
            this.namesTextBox.TabIndex = 1;
            // 
            // FileHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.namesTextBox);
            this.Controls.Add(this.loadButton);
            this.Name = "FileHandler";
            this.Text = "File Handler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox namesTextBox;
    }
}

