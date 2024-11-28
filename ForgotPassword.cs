using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Individual_Project
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {
            var username = nametxt.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
            var name = usernametxt.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Username cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void answertxt_TextChanged(object sender, EventArgs e)
        {
            string answer = answertxt.Text;
            if (string.IsNullOrWhiteSpace(answer))
            {
                MessageBox.Show("Answer cannot be empty.");
            }
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            string password = passwordtxt.Text;
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password cannot be empty.");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();
            this.Close();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            Main_Form mainForm = new Main_Form();
            mainForm.Show();
            this.Hide();
        }
    }
}
