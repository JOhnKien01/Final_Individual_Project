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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void UserNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearleveltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void phonenumbertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup();
            signupForm.Show();
            this.Hide();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            Main_Form mainForm = new Main_Form();
            mainForm.Show();
            this.Hide();
        }
    }
}
