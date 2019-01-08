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
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=WSLKCMP5F-582; user id=sa; password=slk@SOFT; database=Adventure Works");
            string eid = empid.Text;
            string Query = "select * from Tbl_Employee where EmpId ='" + eid + "'";
            SqlDataAdapter sde = new SqlDataAdapter(Query, con);
            DataSet ds = new DataSet();
            sde.Fill(ds, "Tbl_Employee");

            if (ds.Tables[0].Rows.Count != 0)
            {
                Response.Redirect("Update.aspx?eid=" + empid.Text);
            }
            else
            {
                lblMsg.Text = "enter valid employee id";
            }
        }
    }
}