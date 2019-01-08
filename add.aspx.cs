using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace emppro
{

    public partial class WebForm4 : System.Web.UI.Page
    {
        //SqlDataAdapter myadapter;
        SqlCommand mycmd;
        //DataSet myds;
        string Temp;
        static int clickStatus = 0;
        DateTime DateOnly;
        DateTime DateOnly1;
        //int EId;
        //string Ename;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    lblMsg.Text = Request.QueryString["Parameter"].ToString();
            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            {
                if (clickStatus == 0)
                {
                    clickStatus = 1;
                    Button1.Text = "Save";

                }
                else
                {
                    SqlConnection con = new SqlConnection("server=WSLKCMP5F-582; user id=sa; password=slk@SOFT; database=Adventure Works");
                    Temp = "insert into Tbl_Employee (EmpId,EmpName,DOB,Gender,ContactNo,EmailId,DOJ,Department,Designation,Salary,Password1,RoleId,DeleteFlag) values (@Empid,@Empname,@dob,@gender,@Contactno,@Emailid,@doj,@department,@designation,@salary,@password1,@roleid,'N')";
                    mycmd = new SqlCommand(Temp, con);
                    mycmd.Parameters.Add("@Empid", SqlDbType.NChar, 10);
                    mycmd.Parameters.Add("@Empname", SqlDbType.NChar, 20);
                    mycmd.Parameters.Add("@dob", SqlDbType.Date);
                    mycmd.Parameters.Add("@gender", SqlDbType.NChar, 1);
                    mycmd.Parameters.Add("@Contactno", SqlDbType.NChar, 10);
                    mycmd.Parameters.Add("@Emailid", SqlDbType.NVarChar, 20);
                    mycmd.Parameters.Add("@doj", SqlDbType.Date);
                    mycmd.Parameters.Add("@department", SqlDbType.NChar, 30);
                    mycmd.Parameters.Add("@designation", SqlDbType.NChar, 30);
                    mycmd.Parameters.Add("@salary", SqlDbType.Int);
                    mycmd.Parameters.Add("@password1", SqlDbType.NVarChar, 20);
                    mycmd.Parameters.Add("@roleid", SqlDbType.Int);


                    mycmd.Parameters[0].Value = TxtEmpId.Text;
                    mycmd.Parameters[1].Value = TxtEmpName.Text;
                    DateOnly1 = DateTime.Parse(TxtDob.Text);
                    mycmd.Parameters[2].Value = DateOnly1.Date;

                    mycmd.Parameters[3].Value = RadioButtonList1.SelectedItem.Text;
                    mycmd.Parameters[4].Value = TxtContact.Text;
                    mycmd.Parameters[5].Value = TxtEmail.Text;
                    DateOnly = DateTime.Parse(TxtDoj.Text);
                    mycmd.Parameters[6].Value = DateOnly.Date;
                    

                    mycmd.Parameters[7].Value = TxtDept.Text;
                    mycmd.Parameters[8].Value = TxtDesi.Text;
                    mycmd.Parameters[9].Value = Double.Parse(TxtSal.Text);

                    mycmd.Parameters[10].Value = TxtPass.Text;
                    mycmd.Parameters[11].Value = int.Parse(TxtRoleId.Text);
                    try
                    {
                        mycmd.Connection.Open();
                        mycmd.ExecuteNonQuery();
                        mycmd.Connection.Close();

                    }
                    catch (Exception ee)
                    {
                        lblMsg.Text = "error in inserting the record because" + ee.Message.ToString();
                        return;
                    }
                    lblMsg.Text = "Record succesfully added";
                    clickStatus = 0;
                }
            }
       }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TxtEmpId.Text = "";
            TxtEmpName.Text = "";
            TxtDob.Text = "";
            TxtContact.Text = "";
            TxtEmail.Text = "";
            TxtDoj.Text = "";
            TxtDept.Text = "";
            TxtDesi.Text = "";
            TxtSal.Text = "";
            TxtPass.Text = "";
            TxtRoleId.Text = "";
        
        }
    }
}
