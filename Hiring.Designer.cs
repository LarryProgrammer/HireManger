namespace Final_Programming_Project
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
            this.YearSalaryTB = new System.Windows.Forms.TextBox();
            this.CalBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NameProList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.TrainersRadioBtn = new System.Windows.Forms.RadioButton();
            this.AgentRadioBtn = new System.Windows.Forms.RadioButton();
            this.PersonalAssistantRadioBtn = new System.Windows.Forms.RadioButton();
            this.LawyerRadioBtn = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AmountLeftLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AthletePaidLabel = new System.Windows.Forms.Label();
            this.salaryBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the salary for the year (Enter a positive value):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YearSalaryTB
            // 
            this.YearSalaryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearSalaryTB.Location = new System.Drawing.Point(230, 8);
            this.YearSalaryTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.YearSalaryTB.Name = "YearSalaryTB";
            this.YearSalaryTB.Size = new System.Drawing.Size(188, 26);
            this.YearSalaryTB.TabIndex = 1;
            this.YearSalaryTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalBtn
            // 
            this.CalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalBtn.Location = new System.Drawing.Point(23, 265);
            this.CalBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CalBtn.Name = "CalBtn";
            this.CalBtn.Size = new System.Drawing.Size(351, 32);
            this.CalBtn.TabIndex = 2;
            this.CalBtn.Text = "Add new hire\r\n";
            this.CalBtn.UseVisualStyleBackColor = true;
            this.CalBtn.Click += new System.EventHandler(this.CalBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(23, 552);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(180, 32);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(207, 552);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(207, 32);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 87);
            this.label2.TabIndex = 5;
            this.label2.Text = "List of\r\nProfessionals:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameProList
            // 
            this.NameProList.FormattingEnabled = true;
            this.NameProList.Location = new System.Drawing.Point(116, 17);
            this.NameProList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameProList.Name = "NameProList";
            this.NameProList.Size = new System.Drawing.Size(275, 108);
            this.NameProList.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 96);
            this.label3.TabIndex = 7;
            this.label3.Text = "Category of the hired professionals:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.TrainersRadioBtn);
            this.groupBox1.Controls.Add(this.AgentRadioBtn);
            this.groupBox1.Controls.Add(this.PersonalAssistantRadioBtn);
            this.groupBox1.Controls.Add(this.CalBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NameProList);
            this.groupBox1.Controls.Add(this.LawyerRadioBtn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(23, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(395, 311);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Professionals";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(171, 235);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(188, 26);
            this.nameTxt.TabIndex = 22;
            this.nameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TrainersRadioBtn
            // 
            this.TrainersRadioBtn.AutoSize = true;
            this.TrainersRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainersRadioBtn.Location = new System.Drawing.Point(182, 203);
            this.TrainersRadioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrainersRadioBtn.Name = "TrainersRadioBtn";
            this.TrainersRadioBtn.Size = new System.Drawing.Size(79, 21);
            this.TrainersRadioBtn.TabIndex = 21;
            this.TrainersRadioBtn.TabStop = true;
            this.TrainersRadioBtn.Text = "Trainers";
            this.TrainersRadioBtn.UseVisualStyleBackColor = true;
            // 
            // AgentRadioBtn
            // 
            this.AgentRadioBtn.AutoSize = true;
            this.AgentRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentRadioBtn.Location = new System.Drawing.Point(182, 178);
            this.AgentRadioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AgentRadioBtn.Name = "AgentRadioBtn";
            this.AgentRadioBtn.Size = new System.Drawing.Size(63, 21);
            this.AgentRadioBtn.TabIndex = 20;
            this.AgentRadioBtn.TabStop = true;
            this.AgentRadioBtn.Text = "Agent";
            this.AgentRadioBtn.UseVisualStyleBackColor = true;
            // 
            // PersonalAssistantRadioBtn
            // 
            this.PersonalAssistantRadioBtn.AutoSize = true;
            this.PersonalAssistantRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalAssistantRadioBtn.Location = new System.Drawing.Point(182, 153);
            this.PersonalAssistantRadioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PersonalAssistantRadioBtn.Name = "PersonalAssistantRadioBtn";
            this.PersonalAssistantRadioBtn.Size = new System.Drawing.Size(143, 21);
            this.PersonalAssistantRadioBtn.TabIndex = 19;
            this.PersonalAssistantRadioBtn.TabStop = true;
            this.PersonalAssistantRadioBtn.Text = "Personal Assistant";
            this.PersonalAssistantRadioBtn.UseVisualStyleBackColor = true;
            // 
            // LawyerRadioBtn
            // 
            this.LawyerRadioBtn.AutoSize = true;
            this.LawyerRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LawyerRadioBtn.Location = new System.Drawing.Point(182, 128);
            this.LawyerRadioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LawyerRadioBtn.Name = "LawyerRadioBtn";
            this.LawyerRadioBtn.Size = new System.Drawing.Size(71, 21);
            this.LawyerRadioBtn.TabIndex = 18;
            this.LawyerRadioBtn.TabStop = true;
            this.LawyerRadioBtn.Text = "Lawyer";
            this.LawyerRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.AmountLeftLabel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.AthletePaidLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 404);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(395, 144);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Athlete\'s Finances";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Amount the athlete has left:";
            // 
            // AmountLeftLabel
            // 
            this.AmountLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AmountLeftLabel.Location = new System.Drawing.Point(219, 87);
            this.AmountLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AmountLeftLabel.Name = "AmountLeftLabel";
            this.AmountLeftLabel.Size = new System.Drawing.Size(173, 21);
            this.AmountLeftLabel.TabIndex = 6;
            this.AmountLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Total amount the athlete paid:";
            // 
            // AthletePaidLabel
            // 
            this.AthletePaidLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AthletePaidLabel.Location = new System.Drawing.Point(219, 40);
            this.AthletePaidLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AthletePaidLabel.Name = "AthletePaidLabel";
            this.AthletePaidLabel.Size = new System.Drawing.Size(173, 21);
            this.AthletePaidLabel.TabIndex = 2;
            this.AthletePaidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salaryBtn
            // 
            this.salaryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryBtn.Location = new System.Drawing.Point(230, 44);
            this.salaryBtn.Name = "salaryBtn";
            this.salaryBtn.Size = new System.Drawing.Size(188, 27);
            this.salaryBtn.TabIndex = 14;
            this.salaryBtn.Text = "Submit salary";
            this.salaryBtn.UseVisualStyleBackColor = true;
            this.salaryBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 595);
            this.Controls.Add(this.salaryBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.YearSalaryTB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Professional Athletes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YearSalaryTB;
        private System.Windows.Forms.Button CalBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox NameProList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton TrainersRadioBtn;
        private System.Windows.Forms.RadioButton AgentRadioBtn;
        private System.Windows.Forms.RadioButton PersonalAssistantRadioBtn;
        private System.Windows.Forms.RadioButton LawyerRadioBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label AmountLeftLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label AthletePaidLabel;
        private System.Windows.Forms.Button salaryBtn;
        private System.Windows.Forms.TextBox nameTxt;
    }
}

