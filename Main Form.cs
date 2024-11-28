using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_Individual_Project
{
    public partial class Main_Form : Form
    {
        public string username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Birthplace { get; set; }
        public DateTime Birthdate { get; set; }
        public string SelectedSchool { get; set; }
        public string SelectedCourse { get; set; }
        public string YearLevel { get; set; }
        public int IdNumber { get; set; }
        public string SecurityAnswer { get; set; }

        public Main_Form()
        {
            InitializeComponent();
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            name.Text = FullName;
            birthplace.Text = Birthplace;
            email.Text = Email;
            phone.Text = PhoneNumber;
            birthdate.Text = Birthdate.ToShortDateString();
            school.Text = SelectedSchool;
            course.Text = SelectedCourse;
            yearlevel.Text = YearLevel;
            idnumber.Text = IdNumber.ToString();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();
            this.Close();
        }

        private void idNumbertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Profile_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            name.Text = FullName;
        }

        private void birthdate_TextChanged(object sender, EventArgs e)
        {
            birthdate.Text = Birthdate.ToShortDateString();
        }

        private void birthplace_TextChanged(object sender, EventArgs e)
        {
            birthplace.Text = Birthplace;
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {
            phone.Text = PhoneNumber;
        }

        private void school_TextChanged(object sender, EventArgs e)
        {
            school.Text = SelectedSchool;
        }

        private void course_TextChanged(object sender, EventArgs e)
        {
            course.Text = SelectedCourse;
        }

        private void yearlevel_TextChanged(object sender, EventArgs e)
        {
            yearlevel.Text = YearLevel;
        }

        private void idnumber_TextChanged(object sender, EventArgs e)
        {
            idnumber.Text = IdNumber.ToString();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            email.Text = Email;
        }
    }
}
    

