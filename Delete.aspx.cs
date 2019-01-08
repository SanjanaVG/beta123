using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace emppro
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        SqlCommand mycmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=WSLKCMP5F-582; user id=sa; password=slk@SOFT; database=Adventure Works");
            //string Query = "select * from Tbl_Employee where EmpId ='" + Eid.Text + "'";
            //SqlDataAdapter sde = new SqlDataAdapter(Temp, con);
            //DataSet ds = new DataSet();
            //sde.Fill(ds);
                  
                string Temp = "update Tbl_Employee set DeleteFlag='Y' where EmpId=@EmpId";
                mycmd = new SqlCommand(Temp, con);
                mycmd.Parameters.Add("@EmpId", SqlDbType.NVarChar, 10);
                //mycmd.Parameters.Add("Y", SqlDbType.NVarChar, 20);
                mycmd.Parameters[0].Value = Eid.Text;
                try
                {
                    mycmd.Connection.Open();
                    if (mycmd.ExecuteNonQuery() == 0)
                        lblMsg.Text = "record not found";
                    else
                        lblMsg.Text = "Record deleted";
                    mycmd.Connection.Close();

                }
                catch (Exception ee)
                {
                    lblMsg.Text = "error in deleting the record because" + ee.Message.ToString();
                    return;
                }
            }
    }
}