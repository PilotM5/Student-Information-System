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
    public partial class Students : Form
    {
        Functions Con;
        public Students()
        {
            InitializeComponent();
            Con = new Functions();
            ShowStu();
            GetDepartment();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ShowStu()
        {
            string Query = "select * from info_stu";
            dataGridView1.DataSource = Con.GetData(Query);
        }

        private void GetDepartment()
        {
            string Query = "select * from info_dep";
            comboBox2.DisplayMember = Con.GetData(Query).Columns["dep_name"].ToString();
            comboBox2.ValueMember = Con.GetData(Query).Columns["dep_id"].ToString();
            comboBox2.DataSource = Con.GetData(Query);
        }

        private void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "";
            textBox4.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox3.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && dateTimePicker1.Text == "" && textBox4.Text == "" && comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex == -1 && textBox3.Text == "")
            {
                MessageBox.Show("Missing Data !");
            }
            else
            {
                try
                {
                    string StuName = textBox1.Text;
                    string StuGender = comboBox1.SelectedItem.ToString();
                    string StuEmail = textBox2.Text;
                    string StuBorn = dateTimePicker1.Text;                      
                    string StuCity = textBox4.Text;
                    int StuDep = Convert.ToInt32(comboBox2.SelectedValue.ToString());
                    string StuStage = textBox3.Text;

                    string Query = "insert into info_stu values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
                    Query = string.Format(Query, StuName, StuGender, StuEmail, StuBorn, StuCity, StuStage, StuDep);
                    Con.SetData(Query);
                    ShowStu();
                    MessageBox.Show("Student Added ");
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                   // throw;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Department Obj = new Department();
            Obj.Show();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
