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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtRegNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtRegNumber.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =DESKTOP-IEBPTB3\\SQLEXPRESS; database =College; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select fname,mname,duration from NewAdmission where NAID = " + txtRegNumber.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);


                fnameLabel.Text = ds.Tables[0].Rows[0][0].ToString();
                MnameLable.Text = ds.Tables[0].Rows[0][1].ToString();
                durationLable.Text = ds.Tables[0].Rows[0][2].ToString();
            }
            else
            {
                fnameLabel.Text = "_______";
                MnameLable.Text = "_______";
                durationLable.Text = "________";
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-IEBPTB3\\SQLEXPRESS; database =College; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select fname,mname,duration from NewAdmission where NAID = " + txtRegNumber.Text + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);

            if (ds.Tables[0].Rows.Count == 0)
            {

                SqlConnection con1 = new SqlConnection();
                con.ConnectionString = "data source =DESKTOP-IEBPTB3\\SQLEXPRESS; database =College; integrated security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into fees (NAID,fees)values(" + txtRegNumber.Text + "," + txtFees.Text + ")";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                DA.Fill(ds1);

                if (MessageBox.Show("fees submition sucessfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    txtRegNumber.Text = "";
                    txtFees.Text = "";
                    fnameLabel.Text = "_______";
                    MnameLable.Text = "_______";
                    durationLable.Text = "________";
                }
            }
         
        }
        private void Fees_Load(object sender, EventArgs e)
        {

        }
    }
}
