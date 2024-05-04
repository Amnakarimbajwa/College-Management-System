using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace COLLEGEACTIVITY
{
    public partial class New_Admission : Form
    {
        public New_Admission()
        {
            InitializeComponent();
        }

        private void New_Admission_Load(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtFullName.Text;
            String mnane = txtMotherName.Text;
            String gender = "";
            bool isChecked = radioButtonMale.Checked;

            if (isChecked)
            {
                gender = radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text;
            }
            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String semester = txtSemester.Text;
            String program = txtProgramming.Text;
            String sname = txtSchoolName.Text;
            String duration = txtDuration.Text;
            String add = txtAddress.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-IEBPTB3\\SQLEXPRESS; database =College; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewAdmission (fname,mname,gender,dob,mobile,email,semester,prog,sname,duration,addres)VALUES('" + name + "','" + mnane + "','" + gender + "','" + dob + "'," + mobile + ",'" + email + "','" + semester + "','" + program + "','" + sname + "','" + duration + "','" + add + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);

            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();
            MessageBox.Show("Data have been saved,Remember the registration id", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);

           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtAddress.Clear();
            txtMotherName.Clear();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            txtMobile.Clear();
            txtEmail.Clear();
            txtProgramming.ResetText();
            txtSemester.ResetText();
            txtSchoolName.Clear();
            txtDuration.ResetText();
        }

        private void txtProgramming_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}

