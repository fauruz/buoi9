using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b1.Model;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace b1.Model
{
    internal class ConnectDepartment
    {
        public List<Department> getData()
        {
            List<Department> ldp = new List<Department>();
            string constr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            string sql = "Select * from Department";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Department dp = new Department();
                dp.DepartmentId = Convert.ToInt32(rdr.GetString(0));
                dp.DepartmentName = rdr.GetString(1);
                ldp.Add(dp);
            }
            return ldp;
        }
    }
}
