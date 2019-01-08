using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace emppro
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        private string SortExpression;

        protected void Page_Load(object sender, EventArgs e)
        {
            string ConnectionString;

            SqlConnection MyCon;
            ConnectionString = "server=WSLKCMP5F-582;user id=sa;password=slk@SOFT;database=Adventure Works";
            MyCon = new SqlConnection(ConnectionString);
            MyCon.Open();
            string Query = "select EmpId,EmpName,convert(Varchar(10),DOB) as Date_of_Birth,Gender,ContactNo,EmailId,convert(Varchar(10),DOJ)as Date_Of_Joining,Department,Designation,Salary,Password1,RoleId from Tbl_Employee";

            SqlDataAdapter sde = new SqlDataAdapter(Query, MyCon);
            DataSet ds = new DataSet();
            sde.Fill(ds);
            SortExpression = DropDownList1.SelectedValue;
            //Session["Source"] = ds;

            if (ds.Tables[0].Rows.Count != 0)
            {
                //Session["Source"] = ds;


                DataGrid1.DataSource = ds;
                DataGrid1.DataBind();
                lblMsg.Text = "";
                foreach (DataGridColumn col in DataGrid1.Columns)
                {
                    if (col.SortExpression == SortExpression)
                    { //this is the sort column so highlight it
                        col.HeaderStyle.ForeColor = Color.Yellow;
                    }
                    else
                    { //this is not the sort column so use the normal coloring
                        col.HeaderStyle.ForeColor = Color.White;
                    }
                }  // foreach
            }
            else
            {
                lblMsg.Text = "No record found";

            }
        }

        //void Sort_Grid(Object sender, DataGridSortCommandEventArgs e)
        //{

        //    // Retrieve the data source from session state.
        //    DataTable dt = (DataTable)Session["Source"];

        //    // Create a DataView from the DataTable.
        //    DataView dv = new DataView(dt);

        //    // The DataView provides an easy way to sort. Simply set the
        //    // Sort property with the name of the field to sort by.
        //    dv.Sort = e.SortExpression;

        //    // Re-bind the data source and specify that it should be sorted
        //    // by the field specified in the SortExpression property.
        //    DataGrid1.DataSource = dv;
        //    DataGrid1.DataBind();

        //}
    }
}