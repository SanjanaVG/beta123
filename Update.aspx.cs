using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace emppro
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlCommand mycmd;
        string Temp;
        SqlConnection con = new SqlConnection("server=WSLKCMP5F-582; user id=sa; password=slk@SOFT; database=Adventure Works");
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string eid = Request.QueryString["eid"].ToString();

                string Query = "select EmpId,EmpName,DOB,Gender,ContactNo,EmailId,DOJ,Department,Designation,Salary,Password1,RoleId from Tbl_Employee where EmpId ='" + eid + "'";

                SqlDataAdapter sde = new SqlDataAdapter(Query, con);
                DataSet ds = new DataSet();
                //DateTime Date = Convert.ToDateTime(TxtDob.Text);
                sde.Fill(ds, "Tbl_Employee");

                if (ds.Tables[0].Rows.Count != 0)
                {
                    TxtEmpId.Text = eid;
                    TxtEmpName.Text = ds.Tables[0].Rows[0]["EmpName"].ToString();
                    DateTime dob = DateTime.Parse(ds.Tables[0].Rows[0]["DOB"].ToString());
                    TxtDob.Text = dob.ToString("d");
                    //string myDate = dob.ToString();
                    //DateTime dt1 = DateTime.ParseExact(myDate, "dd-MM-yyyy hh:mm:ss:tt", CultureInfo.InvariantCulture);                                                          
                    //Date = dob;
                    //TxtDob.Text = dt1.ToString();
                    if (ds.Tables[0].Rows[0]["Gender"].ToString() == "M")
                    {
                        RadioButtonList1.Items.FindByValue("Male").Selected = true;
                    }
                    else if (ds.Tables[0].Rows[0]["Gender"].ToString() == "F")
                    {
                        RadioButtonList1.Items.FindByValue("Female").Selected = true;
                    }

                    TxtContact.Text = ds.Tables[0].Rows[0]["ContactNo"].ToString();
                    TxtEmail.Text = ds.Tables[0].Rows[0]["EmailId"].ToString();
                    DateTime doj= DateTime.Parse(ds.Tables[0].Rows[0]["DOJ"].ToString());
                    TxtDoj.Text = doj.ToString("d");

                    TxtDept.Text = ds.Tables[0].Rows[0]["Department"].ToString();
                    TxtDesi.Text = ds.Tables[0].Rows[0]["Designation"].ToString();
                    TxtSal.Text = ds.Tables[0].Rows[0]["Salary"].ToString();

                    TxtPass.Text = ds.Tables[0].Rows[0]["Password1"].ToString();
                    TxtRoleId.Text = ds.Tables[0].Rows[0]["RoleId"].ToString();
                }
            }
            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string eid = Request.QueryString["eid"].ToString();
            Temp = "update Tbl_Employee set EmpName=@Empname,DOB=@dob,Gender=@gender,ContactNo=@Contactno,EmailId=@Emailid,DOJ=@doj,Department=@department,Designation=@designation,Salary=@salary,Password1=@password1,RoleId=@roleid where EmpId='" + eid + "'";
                mycmd = new SqlCommand(Temp, con);
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


               
                mycmd.Parameters[0].Value = TxtEmpName.Text;
                mycmd.Parameters[1].Value = TxtDob.Text;
                mycmd.Parameters[2].Value = RadioButtonList1.SelectedItem.Text;
                mycmd.Parameters[3].Value = TxtContact.Text;
                mycmd.Parameters[4].Value = TxtEmail.Text;
                mycmd.Parameters[5].Value = TxtDoj.Text;

                mycmd.Parameters[6].Value = TxtDept.Text;
                mycmd.Parameters[7].Value = TxtDesi.Text;
                mycmd.Parameters[8].Value = Double.Parse(TxtSal.Text);

                mycmd.Parameters[9].Value = TxtPass.Text;
                mycmd.Parameters[10].Value = int.Parse(TxtRoleId.Text);

                try
                {
                    mycmd.Connection.Open();
                    if (mycmd.ExecuteNonQuery() == 0)
                        lblMsg.Text = "record not found";
                    else
                        lblMsg.Text = "record updated";
                    mycmd.Connection.Close();

                }
                catch (Exception ee)
                {
                    lblMsg.Text = "error in updating the record because" + ee.Message.ToString();
                    return;
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