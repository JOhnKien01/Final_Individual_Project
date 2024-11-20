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
            this.answertxt = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.createbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.UserNametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.answertxt);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Controls.Add(this.createbtn);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Passwordtxt);
            this.panel1.Controls.Add(this.Nametxt);
            this.panel1.Controls.Add(this.UserNametxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(200, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 405);
            this.panel1.TabIndex = 0;
            // 
            // answertxt
            // 
            this.answertxt.Location = new System.Drawing.Point(184, 254);
            this.answertxt.Name = "answertxt";
            this.answertxt.Size = new System.Drawing.Size(218, 20);
            this.answertxt.TabIndex = 13;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backbtn.Location = new System.Drawing.Point(309, 312);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(83, 28);
            this.backbtn.TabIndex = 12;
            this.backbtn.Text = "Back";
            this.backbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // createbtn
            // 
            this.createbtn.BackColor = System.Drawing.Color.ForestGreen;
            this.createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createbtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbtn.ForeColor = System.Drawing.Color.White;
            this.createbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createbtn.Location = new System.Drawing.Point(190, 312);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(83, 28);
            this.createbtn.TabIndex = 11;
            this.createbtn.Text = "Create";
            this.createbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createbtn.UseVisualStyleBackColor = false;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Your First Name",
            "Female Friend Name",
            "Male Friend Name"});
            this.comboBox1.Location = new System.Drawing.Point(184, 215);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Answer:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(184, 166);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(218, 20);
            this.Passwordtxt.TabIndex = 6;
            this.Passwordtxt.TextChanged += new System.EventHandler(this.Passwordtxt_TextChanged);
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(184, 121);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(218, 20);
            this.Nametxt.TabIndex = 5;
            this.Nametxt.TextChanged += new System.EventHandler(this.Nametxt_TextChanged);
            // 
            // UserNametxt
            // 
            this.UserNametxt.Location = new System.Drawing.Point(184, 76);
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.Size = new System.Drawing.Size(218, 20);
            this.UserNametxt.TabIndex = 4;
            this.UserNametxt.TextChanged += new System.EventHandler(this.UserNametxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Security Question:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 33);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sign up Form";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 526);
            this.Controls.Add(this.panel1);
            this.Name = "Signup";
            this.Text = "Signup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox UserNametxt;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox answertxt;
        private System.Windows.Forms.Label label6;
    }
}