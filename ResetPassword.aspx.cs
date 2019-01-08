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
    public partial class WebForm6 : System.Web.UI.Page
    {
        SqlCommand mycmd;
        string Temp;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=WSLKCMP5F-582; user id=sa; password=slk@SOFT; database=Adventure Works");

            string empid = (string)Session["empid"];
            string Query = "select EmpId,Password1 from Tbl_Employee where EmpId ='" + empid + "'";
            SqlDataAdapter sde = new SqlDataAdapter(Query, con);
            DataSet ds = new DataSet();
            sde.Fill(ds);
            string oldpass = ds.Tables[0].Rows[0]["Password1"].ToString();
            if (oldpass == current.Text)
            {
                Temp = "update Tbl_Employee set Password1=@password1 where EmpId=@EmpId";
                mycmd = new SqlCommand(Temp, con);
                mycmd.Parameters.Add("@EmpId", SqlDbType.NVarChar, 10);
                mycmd.Parameters.Add("@password1", SqlDbType.NVarChar, 20);
                mycmd.Parameters[0].Value = empid;
                mycmd.Parameters[1].Value = newpass.Text;

                try
                {
                    mycmd.Connection.Open();
                    if (mycmd.ExecuteNonQuery() == 0)
                        lblMsg.Text = "record not found";
                    else
                        lblMsg.Text = "Password updated";
                    mycmd.Connection.Close();

                }
                catch (Exception ee)
                {
                    lblMsg.Text = "error in updating the password because" + ee.Message.ToString();
                    return;
                }
            }
        }
    }
}