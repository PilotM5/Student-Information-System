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
    public partial class Dashboard : Form
    {
        Functions Con;
        public Dashboard()
        {
            InitializeComponent();
            Con = new Functions();
            CountStudents();
            CountDepartments();
            CountMale();
            //CountFemale();
        }
        // Count The Number Student
        private void CountStudents()
        {
            string Query = "select Count(*) as Stud from info_stu";
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                label6.Text = dr["Stud"].ToString();
            }  
        }
        // Count The Number Departments
        private void CountDepartments()
        {
            string Query = "select Count(*) as Dep from info_dep";
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                label18.Text = dr["Dep"].ToString();
            }
        }
        // Count The Number Male 
        private void CountMale()
        {
            string Gen = "Male";
            string Query = "select Count(*) as Male from info_stu where stu_gender = '{0}'";
            Query = string.Format(Query, Gen);
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                label7.Text = dr["Male"].ToString();
            }
        }
        // Count The Number Female
        //private void CountFemale()
        //{
        //    string Gen = "Female";
        //    string Query = "select Count(*) as Female from info_stu where stu_gender = '{1}'";
        //    Query = string.Format(Query, Gen);
        //    foreach (DataRow dr in Con.GetData(Query).Rows)
        //    {
        //        label3.Text = dr["Female"].ToString();
        //    }
        //}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Students Obj = new Students();
            Obj.Show();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Department Obj = new Department();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
