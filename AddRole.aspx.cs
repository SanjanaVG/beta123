using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace emppro
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        SqlCommand mycmd;
        string Temp;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=WSLKCMP5F-582; user id=sa; password=slk@SOFT; database=Adventure Works");
            Temp = "insert into Tbl_Role(RoleId,Roles) values(@roleid,@roles)";
            mycmd = new SqlCommand(Temp, con);
            mycmd.Parameters.Add("@roleid", SqlDbType.Int);
            mycmd.Parameters.Add("@roles", SqlDbType.NChar, 50);
            mycmd.Parameters[0].Value = int.Parse(TextBox1.Text);
            mycmd.Parameters[1].Value = TextBox2.Text;
            try
            {
                mycmd.Connection.Open();
                mycmd.ExecuteNonQuery();
                mycmd.Connection.Close();

            }
            catch (Exception ee)
            {
                lblMsg.Text = "error in inserting the role because" + ee.Message.ToString();
                return;
            }
            lblMsg.Text = "Role succesfully added";

        }
    }
}