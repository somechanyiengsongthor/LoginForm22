using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm2
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = text_UserName.Text;
            string password = text_Password.Text;

            if (username == "ceeb" && password == "1234")
            {
                net_form fh = new net_form();
                fh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Plabelease check your Username or Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label_UserName_Click(object sender, EventArgs e)
        {

        }

        private void text_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
