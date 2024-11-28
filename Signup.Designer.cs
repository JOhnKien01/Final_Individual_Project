namespace Final_Individual_Project
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.idnotxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Birthdate = new System.Windows.Forms.DateTimePicker();
            this.school = new System.Windows.Forms.ComboBox();
            this.yearlevel = new System.Windows.Forms.ComboBox();
            this.course = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.birthtxt = new System.Windows.Forms.TextBox();
            this.UserNametxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.answertxt = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.submitbtn = new System.Windows.Forms.Button();
            this.security = new System.Windows.Forms.ComboBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.idnotxt);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.Birthdate);
            this.panel1.Controls.Add(this.school);
            this.panel1.Controls.Add(this.yearlevel);
            this.panel1.Controls.Add(this.course);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.birthtxt);
            this.panel1.Controls.Add(this.UserNametxt);
            this.panel1.Controls.Add(this.phonetxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 405);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // idnotxt
            // 
            this.idnotxt.Location = new System.Drawing.Point(172, 381);
            this.idnotxt.Name = "idnotxt";
            this.idnotxt.Size = new System.Drawing.Size(225, 20);
            this.idnotxt.TabIndex = 21;
            this.idnotxt.TextChanged += new System.EventHandler(this.idnotxt_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(45, 382);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 22);
            this.label14.TabIndex = 20;
            this.label14.Text = "School ID no.:";
            // 
            // Birthdate
            // 
            this.Birthdate.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthdate.Location = new System.Drawing.Point(172, 121);
            this.Birthdate.MaxDate = new System.DateTime(2024, 12, 25, 23, 59, 59, 0);
            this.Birthdate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Size = new System.Drawing.Size(225, 20);
            this.Birthdate.TabIndex = 19;
            this.Birthdate.ValueChanged += new System.EventHandler(this.Birthdate_ValueChanged);
            // 
            // school
            // 
            this.school.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.school.FormattingEnabled = true;
            this.school.Items.AddRange(new object[] {
            "Data Center College of the Philippines of Baguio City, Inc."});
            this.school.Location = new System.Drawing.Point(172, 254);
            this.school.Name = "school";
            this.school.Size = new System.Drawing.Size(225, 21);
            this.school.TabIndex = 16;
            this.school.SelectedIndexChanged += new System.EventHandler(this.school_SelectedIndexChanged);
            // 
            // yearlevel
            // 
            this.yearlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearlevel.FormattingEnabled = true;
            this.yearlevel.Items.AddRange(new object[] {
            "First Year",
            "Second Year",
            "Third Year",
            "Fourth Year"});
            this.yearlevel.Location = new System.Drawing.Point(172, 339);
            this.yearlevel.Name = "yearlevel";
            this.yearlevel.Size = new System.Drawing.Size(225, 21);
            this.yearlevel.TabIndex = 18;
            this.yearlevel.SelectedIndexChanged += new System.EventHandler(this.yearlevel_SelectedIndexChanged);
            // 
            // course
            // 
            this.course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course.FormattingEnabled = true;
            this.course.Items.AddRange(new object[] {
            "Bachelor of Science in Business Administration ",
            "Bachelor of Science in Hospitality Management",
            "Bachelor of Science in Information Technology",
            "DHRT"});
            this.course.Location = new System.Drawing.Point(172, 298);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(225, 21);
            this.course.TabIndex = 17;
            this.course.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, -5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 33);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sign up Form";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Phone Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Year Level:";
            // 
            // birthtxt
            // 
            this.birthtxt.Location = new System.Drawing.Point(172, 166);
            this.birthtxt.Name = "birthtxt";
            this.birthtxt.Size = new System.Drawing.Size(225, 20);
            this.birthtxt.TabIndex = 6;
            this.birthtxt.TextChanged += new System.EventHandler(this.Passwordtxt_TextChanged);
            // 
            // UserNametxt
            // 
            this.UserNametxt.Location = new System.Drawing.Point(172, 76);
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.Size = new System.Drawing.Size(225, 20);
            this.UserNametxt.TabIndex = 4;
            this.UserNametxt.TextChanged += new System.EventHandler(this.UserNametxt_TextChanged);
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(172, 209);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(225, 20);
            this.phonetxt.TabIndex = 5;
            this.phonetxt.TextChanged += new System.EventHandler(this.Nametxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Birth Place:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "Birth Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "School:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Course:";
            // 
            // answertxt
            // 
            this.answertxt.Location = new System.Drawing.Point(184, 251);
            this.answertxt.Name = "answertxt";
            this.answertxt.Size = new System.Drawing.Size(218, 20);
            this.answertxt.TabIndex = 13;
            this.answertxt.TextChanged += new System.EventHandler(this.answertxt_TextChanged);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backbtn.Location = new System.Drawing.Point(343, 357);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(83, 28);
            this.backbtn.TabIndex = 12;
            this.backbtn.Text = "Back";
            this.backbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Answer:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Security Question:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.passtxt);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.backbtn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.answertxt);
            this.panel2.Controls.Add(this.submitbtn);
            this.panel2.Controls.Add(this.security);
            this.panel2.Controls.Add(this.emailtxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Usertxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(420, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 405);
            this.panel2.TabIndex = 2;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(184, 162);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(218, 20);
            this.passtxt.TabIndex = 17;
            this.passtxt.TextChanged += new System.EventHandler(this.passtxt_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(43, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 22);
            this.label13.TabIndex = 16;
            this.label13.Text = "E-mail Address:";
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.ForestGreen;
            this.submitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitbtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ForeColor = System.Drawing.Color.White;
            this.submitbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.submitbtn.Location = new System.Drawing.Point(208, 357);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(83, 28);
            this.submitbtn.TabIndex = 11;
            this.submitbtn.Text = "Submit";
            this.submitbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // security
            // 
            this.security.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.security.FormattingEnabled = true;
            this.security.Items.AddRange(new object[] {
            "Your First Love?",
            "Your Girlfriend\'s Name?",
            "Your Boyfriend\'s Name?",
            "Your Female Friend\'s Name?",
            "Your Male Friend\'s Name?"});
            this.security.Location = new System.Drawing.Point(208, 206);
            this.security.Name = "security";
            this.security.Size = new System.Drawing.Size(218, 21);
            this.security.TabIndex = 9;
            this.security.SelectedIndexChanged += new System.EventHandler(this.security_SelectedIndexChanged);
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(184, 121);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(218, 20);
            this.emailtxt.TabIndex = 5;
            this.emailtxt.TextChanged += new System.EventHandler(this.emailtxt_TextChanged);
            // 
            // Usertxt
            // 
            this.Usertxt.Location = new System.Drawing.Point(184, 76);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(218, 20);
            this.Usertxt.TabIndex = 4;
            this.Usertxt.TextChanged += new System.EventHandler(this.Usertxt_TextChanged);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 526);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Signup";
            this.Text = "Signup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox birthtxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.TextBox UserNametxt;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox answertxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox course;
        private System.Windows.Forms.ComboBox school;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.ComboBox security;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox yearlevel;
        private System.Windows.Forms.DateTimePicker Birthdate;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox idnotxt;
    }
}