using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;
using System.Configuration;

namespace emppro
{
    /// <summary>
    /// Summary description for autoHandler1
    /// </summary>
    [WebService(Namespace = "http://tempurl.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]

    public class autoHandler1 : System.Web.Services.WebService
    {
        [WebMethod]
        public List<string> getEmpName(string Empname)
        {
            string ConnectionString = "server=WSLKCMP5F-582; user id=sa; password=slk@SOFT; database=Adventure Works";
            List<string> names = new List<string>();
            using (SqlConnection MyCon = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("spgetEmpName", MyCon);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = new SqlParameter("@name", Empname);
                cmd.Parameters.Add(para);

                MyCon.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    names.Add(rdr["EmpName"].ToString());
                }
            }
            return names;
        }














        //public class autoHandler1 : IHttpHandler
        //{

        //    public void ProcessRequest(HttpContext context)
        //    {
        //        string name = context.Request["name"] ?? "";
        //        string ConnectionString;
        //        List<string> empna = new List<string>();

        //        ConnectionString = "server=WSLKCMP5F-582; user id=sa; password=slk@SOFT; database=Adventure Works";
        //        using (SqlConnection MyCon = new SqlConnection(ConnectionString))
        //        {
        //            SqlCommand cmd = new SqlCommand("getempname", MyCon);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.Add(new SqlParameter()
        //            {
        //                ParameterName = "@name",
        //                Value = name
        //            });
        //        MyCon.Open();
        //            SqlDataReader rdr = cmd.ExecuteReader();
        //            while(rdr.Read())
        //            {
        //                empna.Add(rdr["EmpName"].ToString());
        //            }
        //    }

        //        JavaScriptSerializer js = new JavaScriptSerializer();
        //        context.Response.Write(js.Serialize(empna));
        //    }

        //    public bool IsReusable
        //    {
        //        get
        //        {
        //            return false;
        //        }
        //    }
        //}
    }
}