namespace Searching
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
            this.searchButton = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.resultsLabel1 = new System.Windows.Forms.Label();
            this.resultsLabel2 = new System.Windows.Forms.Label();
            this.stringList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(43, 215);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "search for";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchText
            // 
            this.searchText.BackColor = System.Drawing.SystemColors.Info;
            this.searchText.Location = new System.Drawing.Point(152, 215);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(100, 20);
            this.searchText.TabIndex = 2;
            // 
            // resultsLabel1
            // 
            this.resultsLabel1.AutoSize = true;
            this.resultsLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel1.Location = new System.Drawing.Point(50, 256);
            this.resultsLabel1.Name = "resultsLabel1";
            this.resultsLabel1.Size = new System.Drawing.Size(48, 15);
            this.resultsLabel1.TabIndex = 3;
            this.resultsLabel1.Text = "Results";
            // 
            // resultsLabel2
            // 
            this.resultsLabel2.AutoSize = true;
            this.resultsLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel2.Location = new System.Drawing.Point(152, 256);
            this.resultsLabel2.Name = "resultsLabel2";
            this.resultsLabel2.Size = new System.Drawing.Size(0, 15);
            this.resultsLabel2.TabIndex = 4;
            // 
            // stringList
            // 
            this.stringList.Location = new System.Drawing.Point(155, 12);
            this.stringList.Multiline = true;
            this.stringList.Name = "stringList";
            this.stringList.Size = new System.Drawing.Size(67, 148);
            this.stringList.TabIndex = 5;
            this.stringList.TextChanged += new System.EventHandler(this.stringList_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter your list";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stringList);
            this.Controls.Add(this.resultsLabel2);
            this.Controls.Add(this.resultsLabel1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.searchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label resultsLabel1;
        private System.Windows.Forms.Label resultsLabel2;
        private System.Windows.Forms.TextBox stringList;
        private System.Windows.Forms.Label label2;
    }
}

