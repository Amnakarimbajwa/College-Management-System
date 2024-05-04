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
    public partial class upgradesemester : Form
    {
        public upgradesemester()
        {
            InitializeComponent();
        }

       

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("semester update warning!", "confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =DESKTOP-IEBPTB3\\SQLEXPRESS; database =College; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update NewAdmission set semester = '" + ComboBoxTo.Text + "' where semester= '" + ComboBoxFrom.Text + "'";
      
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                
            }
        }

        private SqlConnection SqlConnection()
        {
            throw new NotImplementedException();
        }
    }
}
