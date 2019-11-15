namespace GitHubPatch
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
            this.label2 = new System.Windows.Forms.Label();
            this.uidTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // uidTextBox
            // 
            this.uidTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidTextBox.Location = new System.Drawing.Point(204, 77);
            this.uidTextBox.Name = "uidTextBox";
            this.uidTextBox.Size = new System.Drawing.Size(100, 26);
            this.uidTextBox.TabIndex = 2;
            this.uidTextBox.TextChanged += new System.EventHandler(this.UidTextBox_TextChanged);
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox1.Location = new System.Drawing.Point(204, 123);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.PasswordChar = '*';
            this.passwordTextBox1.Size = new System.Drawing.Size(100, 26);
            this.passwordTextBox1.TabIndex = 3;
            this.passwordTextBox1.TextChanged += new System.EventHandler(this.PasswordBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Proxy Patch";
            // 
            // applyButton
            // 
            this.applyButton.Enabled = false;
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.applyButton.Location = new System.Drawing.Point(98, 200);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(125, 32);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Apply Patch";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ReEnter Password";
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox2.Location = new System.Drawing.Point(204, 160);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.PasswordChar = '*';
            this.passwordTextBox2.Size = new System.Drawing.Size(100, 26);
            this.passwordTextBox2.TabIndex = 7;
            this.passwordTextBox2.TextChanged += new System.EventHandler(this.PasswordTextBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Version";
            // 
            // versionTextBox
            // 
            this.versionTextBox.Location = new System.Drawing.Point(225, 268);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.Size = new System.Drawing.Size(58, 20);
            this.versionTextBox.TabIndex = 9;
            this.versionTextBox.Text = "app-2.2.1";
            this.versionTextBox.TextChanged += new System.EventHandler(this.versionTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 319);
            this.Controls.Add(this.versionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTextBox1);
            this.Controls.Add(this.uidTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uidTextBox;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox versionTextBox;
    }
}

