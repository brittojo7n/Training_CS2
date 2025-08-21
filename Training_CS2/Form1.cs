using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Training_CS2
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> userCredentials = new Dictionary<string, string>
        {
            { "dave", "2345" },
            { "sam", "1234" }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Username and password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (userCredentials.ContainsKey(username) && userCredentials[username] == password)
                {
                    string logFolderName = "LoginLogs";
                    string projectDirectory = Application.StartupPath;
                    string logFolderPath = Path.Combine(projectDirectory, logFolderName);

                    Directory.CreateDirectory(logFolderPath);

                    string fileName = username + "_login_log.txt";
                    string filePath = Path.Combine(logFolderPath, fileName);
                    string logContent = $"User '{username}' logged in on: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}\n";
                    
                    try { 
                        File.AppendAllText(filePath, logContent);
                        MessageBox.Show($"A log file has been created on your desktop: { fileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex) { MessageBox.Show("An unexpected error occurred: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Stop); }

                    MessageBox.Show($"Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
