namespace PersonExample
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maxNumOfStudentsBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.studentNameBox = new System.Windows.Forms.TextBox();
            this.studentAgeBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.currentNumOfStudentsBox = new System.Windows.Forms.TextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.teacherNameBox = new System.Windows.Forms.TextBox();
            this.studentPanel = new System.Windows.Forms.Panel();
            this.studentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(106, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Console";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(109, 61);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Max num of students";
            // 
            // maxNumOfStudentsBox
            // 
            this.maxNumOfStudentsBox.Location = new System.Drawing.Point(136, 111);
            this.maxNumOfStudentsBox.Name = "maxNumOfStudentsBox";
            this.maxNumOfStudentsBox.Size = new System.Drawing.Size(34, 20);
            this.maxNumOfStudentsBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Student Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Student Age";
            // 
            // studentNameBox
            // 
            this.studentNameBox.Location = new System.Drawing.Point(117, 59);
            this.studentNameBox.Name = "studentNameBox";
            this.studentNameBox.Size = new System.Drawing.Size(147, 20);
            this.studentNameBox.TabIndex = 7;
            // 
            // studentAgeBox
            // 
            this.studentAgeBox.Location = new System.Drawing.Point(117, 100);
            this.studentAgeBox.Name = "studentAgeBox";
            this.studentAgeBox.Size = new System.Drawing.Size(100, 20);
            this.studentAgeBox.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(96, 136);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Current num of students";
            // 
            // currentNumOfStudentsBox
            // 
            this.currentNumOfStudentsBox.Location = new System.Drawing.Point(157, 21);
            this.currentNumOfStudentsBox.Name = "currentNumOfStudentsBox";
            this.currentNumOfStudentsBox.Size = new System.Drawing.Size(34, 20);
            this.currentNumOfStudentsBox.TabIndex = 11;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(96, 178);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 28);
            this.displayButton.TabIndex = 12;
            this.displayButton.Text = "display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(109, 190);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 13;
            this.createButton.Text = "create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Teacher";
            // 
            // teacherNameBox
            // 
            this.teacherNameBox.Location = new System.Drawing.Point(136, 154);
            this.teacherNameBox.Name = "teacherNameBox";
            this.teacherNameBox.Size = new System.Drawing.Size(100, 20);
            this.teacherNameBox.TabIndex = 15;
            // 
            // studentPanel
            // 
            this.studentPanel.Controls.Add(this.label6);
            this.studentPanel.Controls.Add(this.currentNumOfStudentsBox);
            this.studentPanel.Controls.Add(this.label4);
            this.studentPanel.Controls.Add(this.studentNameBox);
            this.studentPanel.Controls.Add(this.displayButton);
            this.studentPanel.Controls.Add(this.label5);
            this.studentPanel.Controls.Add(this.addButton);
            this.studentPanel.Controls.Add(this.studentAgeBox);
            this.studentPanel.Location = new System.Drawing.Point(19, 233);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(268, 215);
            this.studentPanel.TabIndex = 16;
            this.studentPanel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 459);
            this.Controls.Add(this.studentPanel);
            this.Controls.Add(this.teacherNameBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.maxNumOfStudentsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.studentPanel.ResumeLayout(false);
            this.studentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maxNumOfStudentsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox studentNameBox;
        private System.Windows.Forms.TextBox studentAgeBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox currentNumOfStudentsBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox teacherNameBox;
        private System.Windows.Forms.Panel studentPanel;
    }
}