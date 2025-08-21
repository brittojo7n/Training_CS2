using System;
using System.Windows.Forms;

namespace Training_CS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void verifyButton_Click_1(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            MessageBox.Show(username + " verified");
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
