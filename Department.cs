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
    public partial class Department : Form
    {
        Functions Con;
        public Department()
        {
            InitializeComponent();
            Con = new Functions();
            ShowDep();
        }

        private void ShowDep()
        {
            string Query = "select * from info_dep";
            dataGridView1.DataSource = Con.GetData(Query);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            textBox1.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox4.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Missing Data !");
            }
            else
            {
                try
                {
                    string DepName = textBox1.Text;
                    string OpenYear = textBox4.Text;
                    string Desc = textBox2.Text;
                    string NumSeats = textBox3.Text;
                    string Query = "insert into info_dep values('{0}','{1}','{2}','{3}')";
                    Query = string.Format(Query, DepName, OpenYear, Desc, NumSeats);
                    Con.SetData(Query);
                    //if (NumSeats == "")
                    //{
                    //    Query = "insert into info_dep where  ";
                    //}
                    MessageBox.Show("Department Added ");
                    Clear();
                }
                catch (Exception Ex)
                {
                    throw;
                }
            }
        }

        int key = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            //if (key == 0)
            //{
            //    MessageBox.Show("Shoud a Select ");
            //}
            //else
            //{
            //    try
            //    {
            //        string DepName = textBox1.Text;
            //        string stage = textBox4.Text;
            //        string Query = "Delete from into info_dep where dep_id = {0}";
            //        Query = string.Format(Query, key);
            //        Con.SetData(Query);
            //        MessageBox.Show("Department Deleted ");
            //    }
            //    catch (Exception Ex)
            //    {
            //        throw;
            //    }
            //} 
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Students Obj = new Students();
            Obj.Show();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
