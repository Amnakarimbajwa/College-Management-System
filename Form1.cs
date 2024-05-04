using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COLLEGEACTIVITY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            string password = textBox1.Text;

            if(username == "student"&& password == "student")
            {
                menuStrip1 .Visible = true;
                panel1 .Visible = false;
            }
            else
            {
                MessageBox.Show("invalid userid or password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Admission new_Admission = new New_Admission();
            new_Admission.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void upgradeSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upgradesemester us = new upgradesemester();
            us.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees fs = new Fees();
            fs.Show();
        }

        private void searchStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudent ss = new SearchStudent();
            ss.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void individualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            individual_search_form sid = new individual_search_form();
            sid.Show();
        }

        private void addTeachersInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teacher_info inf= new teacher_info();
            inf.Show();
        }
    }
}
