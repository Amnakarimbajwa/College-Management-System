using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COLLEGEACTIVITY
{
    public partial class SearchStudent : Form
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-IEBPTB3\\SQLEXPRESS; database =College; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select NewAdmission.NAID as Student_ID ,NewAdmission.fname as Full_name, NewAdmission.mname as Mother_Name,NewAdmission.gender as Gender,NewAdmission.dob as Date_Of_Birth, NewAdmission.mobile as Mobile, NewAdmission.email as E_mail, NewAdmission.semester, NewAdmission.prog as Programming, NewAdmission.sname as school_Name, NewAdmission.duration as Course_Duration, NewAdmission.addres as Address, fees.fees as Fees from NewAdmission inner join fees on NewAdmission.NAID=fees.NAID";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-IEBPTB3\\SQLEXPRESS; database =College; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select *from NewAdmission where NAID =" + textBox1.Text + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }
    }
}
