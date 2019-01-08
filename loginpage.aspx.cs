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
    public partial class WebForm1 : System.Web.UI.Page
    {
        static int clickStatus = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string EmpId = TxtUsername.Text;
                string Pass = TxtPassword.Text;
                string ConnectionString;
            SqlConnection MyCon;
            ConnectionString = "server=WSLKCMP5F-582; user id=sa; password=slk@SOFT; database=Adventure Works";
            MyCon = new SqlConnection(ConnectionString);
            MyCon.Open();
            string Query = "select * from Tbl_Employee where EmpId='" + EmpId + "' and Password1='" + Pass + "' ";
                SqlCommand cmd = new SqlCommand(Query, MyCon);
                SqlDataReader Sdr = cmd.ExecuteReader();
                if (Sdr.Read())
                {
                    int Role = (int)Sdr["RoleId"];
                    string df = (string)Sdr["DeleteFlag"];
                    string empname = (string)Sdr["EmpName"];
                    Session.Add("Name",empname);
                    Session.Add("empid",EmpId );
                    Session.Add("Role1", Role);
                    Session.Add("df1", df);
                    if (Role == 20001 && df == "N")
                    {
                        Response.Redirect("admin.aspx", true);
                    }
                    else if (Role != 20001 && df == "N")
                    {
                        if(Pass!="pass1234")
                        Response.Redirect("search.aspx", true);
                        else
                        Response.Redirect("ResetPassword.aspx", true);

                    }
                    else
                    {
                        lblMsg.Text = "User doesn't exist";
                    }
                }
                else
                    {
                    
                    lblMsg.Text = "Invalid username or password";
                    }
                MyCon.Close();
            }
            catch(Exception ee)
            {
                lblMsg.Text = "the error is"+ee;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (clickStatus == 0)
            {
                TxtUsername.Text = "";
                TxtPassword.Text = "";
            }
        }
    }
}
    
