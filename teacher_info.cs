using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace COLLEGEACTIVITY
{
    public partial class teacher_info : Form
    {
        public teacher_info()
        {
            InitializeComponent();
        }

        private void teacher_info_Load(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            String gender = "";
            bool isChecked = radiomale.Checked;

            if (isChecked)
            {
                gender = radiomale.Text;
            }
            else
            {
                gender = radiofemale.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =DESKTOP-IEBPTB3\\SQLEXPRESS; database =College; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into teacher (fname,gender,dob,mobile,email,semester,prog,years,adres)VALUES('" + txtFName.Text + "','" + gender + "','" + dateTimePickerDOB + "','" + txtMobile.Text + "','" + txtEmail.Text + "','" + txtSemester.Text + "','" + txtProgram.Text + "','" + txtDuration.Text + "','" + txtAddress.Text + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);

                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show("Data have been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

