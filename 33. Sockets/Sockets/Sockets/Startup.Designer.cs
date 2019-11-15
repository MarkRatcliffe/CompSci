namespace Sockets
{
    partial class Startup
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
            this.masterButton = new System.Windows.Forms.Button();
            this.slaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // masterButton
            // 
            this.masterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterButton.Location = new System.Drawing.Point(95, 60);
            this.masterButton.Name = "masterButton";
            this.masterButton.Size = new System.Drawing.Size(143, 28);
            this.masterButton.TabIndex = 0;
            this.masterButton.Text = "Launch Master";
            this.masterButton.UseVisualStyleBackColor = true;
            this.masterButton.Click += new System.EventHandler(this.masterButton_Click);
            // 
            // slaveButton
            // 
            this.slaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slaveButton.Location = new System.Drawing.Point(95, 126);
            this.slaveButton.Name = "slaveButton";
            this.slaveButton.Size = new System.Drawing.Size(143, 28);
            this.slaveButton.TabIndex = 1;
            this.slaveButton.Text = "Launch Slave";
            this.slaveButton.UseVisualStyleBackColor = true;
            this.slaveButton.Click += new System.EventHandler(this.slaveButton_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.slaveButton);
            this.Controls.Add(this.masterButton);
            this.Name = "Startup";
            this.Text = "Startup Form";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button masterButton;
        private System.Windows.Forms.Button slaveButton;
    }
}

