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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {}
        private void label1_Click(object sender, EventArgs e)
        {}

        private void Username_TextChanged(object sender, EventArgs e)
        {
            // Get the current input
            string input = Username.Text;

            // Simulated saved usernames (replace with database integration if necessary)
            List<string> savedUsernames = new List<string> { "user", "admin", "guest", "john","eric" };

            // 1. Real-time Validation: Check if the username is empty
            if (string.IsNullOrWhiteSpace(input))
            {
                Loginbtn.Enabled = false; // Disable login button
                MessageBox.Show("Username cannot be empty.");
                return;
            }
            else
            {
                Loginbtn.Enabled = true; // Enable login button
            }
            // 2. Restrict Input: Allow only alphanumeric characters
            if (!System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z0-9]*$"))
            {
                MessageBox.Show("Username can only contain letters and numbers.");
                Username.Text = input.Remove(input.Length - 1); // Remove the last invalid character
                Username.SelectionStart = Username.Text.Length; // Set cursor at the end
                return;
            }
            // 3. Character Limit: Ensure username is within the limit
            const int maxCharacters = 20;
            if (input.Length > maxCharacters)
            {
                MessageBox.Show($"Username cannot exceed {maxCharacters} characters.");
                Username.Text = input.Substring(0, maxCharacters); // Truncate to the limit
                Username.SelectionStart = Username.Text.Length; // Reset cursor position
                return;
            }
            // 4. Check Saved Usernames
            if (savedUsernames.Contains(input, StringComparer.OrdinalIgnoreCase))
            {
                // Username exists
                MessageBox.Show($"Welcome back, {input}!");
                Loginbtn.Enabled = true; // Allow login
                return;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        { }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            // Mask the password field
            Password.PasswordChar = '*';

            // Get the current username and password input
            string enteredUsername = Username.Text;
            string enteredPassword = Password.Text;

            // Simulated user data (replace with database integration if necessary)
            Dictionary<string, string> userCredentials = new Dictionary<string, string>
                {
                { "user", "user123" },
                { "admin", "admin123" },
                { "guest", "guest123" },
                { "john", "john123" },
                { "eric", "eric123" }
    };

            // Check if username exists in the saved records
            if (!userCredentials.ContainsKey(enteredUsername))
            {
                MessageBox.Show("Username not recognized. Please enter a valid username or sign up.");
                Loginbtn.Enabled = false; // Disable login button
                return;
            }
        }
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            // Get the current username and password input
            string enteredUsername = Username.Text;
            string enteredPassword = Password.Text;

            // Simulated user data (replace with database integration if necessary)
            Dictionary<string, string> userCredentials = new Dictionary<string, string>
    {
                { "user", "user123" },
                { "admin", "admin123" },
                { "guest", "guest123" },
                { "john", "john123" },
                { "eric", "eric123" }
    };

            // Validate the username and password
            if (userCredentials.ContainsKey(enteredUsername) && userCredentials[enteredUsername] == enteredPassword)
            {
                // Username and password are correct
                MessageBox.Show($"Welcome, {enteredUsername}!");

                // Proceed to the final form
                Main_Form mainForm = new Main_Form();
                mainForm.Show();
                this.Hide(); // Hide the current login form
            }
             else
            {
                // Username or password is incorrect
                MessageBox.Show("Invalid username or password. Please try again.");
            }
    }
        private void Signupbtn_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup();
            signupForm.Show();
            this.Hide();
        }
        private void Forgotpasswordbtn_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPasswordForm = new ForgotPassword();
            forgotPasswordForm.Show();
            this.Hide();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Trouble_login troubleLoginForm = new Trouble_login();
            troubleLoginForm.Show();
            this.Hide();   
        }
    }
    }
    

