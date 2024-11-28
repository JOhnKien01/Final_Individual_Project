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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final_Individual_Project
{
    public partial class Signup : Form
    { 
        public Signup()
        {
            InitializeComponent();
            Birthdate.Value = DateTime.Now;
            Birthdate.ValueChanged += Birthdate_ValueChanged;
        }

        private void UserNametxt_TextChanged(object sender, EventArgs e)
        {
            var FullName = UserNametxt.Text;
            if (string.IsNullOrWhiteSpace(FullName))
            {
                MessageBox.Show("Username cannot be empty.", "Sign up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = phonetxt.Text;
            if (phoneNumber.Length == 10)
            {
                if (!long.TryParse(phoneNumber, out _))
                {
                    MessageBox.Show("Please enter a valid phone number.");
                    phonetxt.Focus();
                    return;
                }
            }
        }

        private void Passwordtxt_TextChanged(object sender, EventArgs e)
        {
            var birthplace = birthtxt.Text;
            if (string.IsNullOrWhiteSpace(birthplace))
            {
                MessageBox.Show("Birthplace cannot be empty.", "Birth Place", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Securityquestiontxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createbtn_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Birthdate_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker birthdatePicker = sender as DateTimePicker;

            if (birthdatePicker != null)
            {
                DateTime selectedDate = birthdatePicker.Value;

                if (selectedDate > DateTime.Now)
                {
                    MessageBox.Show("Birthdate cannot be in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    birthdatePicker.Value = DateTime.Now;
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourse = null;
            if (course.SelectedItem != null)
            {
                selectedCourse = course.SelectedItem.ToString();
            }
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            Main_Form mainForm = new Main_Form
            {
                username = Usertxt.Text.Trim(),
                FullName = UserNametxt.Text.Trim(),
                Email = emailtxt.Text.Trim(),
                PhoneNumber = phonetxt.Text.Trim(),
                Birthplace = birthtxt.Text.Trim(),
                Birthdate = Birthdate.Value,
                SelectedSchool = school.SelectedItem?.ToString(),
                SelectedCourse = course.SelectedItem?.ToString(),
                YearLevel = yearlevel.SelectedItem?.ToString(),
                SecurityAnswer = answertxt.Text.Trim(),
            };

            // Validate and parse the ID number
            if (int.TryParse(idnotxt.Text.Trim(), out int idNumber))
            {
                mainForm.IdNumber = idNumber;
            }
            else
            {
                MessageBox.Show("Please enter a valid ID number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Show the Main_Form and hide the Signup form
            mainForm.Show();
            this.Hide();
        }


        private void school_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSchool = null; 
            if (school.SelectedItem != null) 
            {
                selectedSchool = school.SelectedItem.ToString();
            }
        }

        private void idnotxt_TextChanged(object sender, EventArgs e)
        {
            bool isValidId = int.TryParse(idnotxt.Text, out int idNumber);
            if (!isValidId || idNumber <= 0)
            {
                // Show an error message if the input is not a valid number or less than or equal to 0
                MessageBox.Show("Enter a valid ID number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void security_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSecurity = null;
            if (security.SelectedItem != null)
            {
                selectedSecurity = security.SelectedItem.ToString();
            }
        }

        private void yearlevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedYearLevel = null; // Initialize variable to hold the selection
            if (yearlevel.SelectedItem != null) // Check if an item is selected
            {
                selectedYearLevel = yearlevel.SelectedItem.ToString();
            }
                
        }

        private void Usertxt_TextChanged(object sender, EventArgs e)
        {
            string username = Usertxt.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username cannot be empty.");
            }
        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {
            string email = emailtxt.Text;
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("E-mail cannot be empty.");
            }
        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {
            string password = passtxt.Text;
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password cannot be empty.");
            }
        }

        private void answertxt_TextChanged(object sender, EventArgs e)
        {
            string answer = answertxt.Text;
            if (string.IsNullOrWhiteSpace(answer))
            {
                MessageBox.Show("Answer cannot be empty.") ;
            }
        }
    }
}

