using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS_DB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else if (textBox1.Text == "admin" && textBox2.Text == "password")
            {
                Students Obj = new Students();
                Obj.Show();
                this.Hide();
            }
            else 
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
