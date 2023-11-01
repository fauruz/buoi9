using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b1.Models
{
    internal class ConnectStudent
    {
        public List<Student> getData()
        {
            List<Student> lsd = new List<Student>();
            string constr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "select * from Student";
                da.SelectCommand.Connection = con;
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    Student sd = new Student();
                    sd.Id = Convert.ToInt32(row["Id"].ToString());
                    sd.Name = row["Name"].ToString();
                    sd.Gender = Convert.ToInt32(row["Gender"].ToString());
                    sd.Year = Convert.ToInt32(row["Year"].ToString());
                    sd.DpId = Convert.ToInt32(row["DpId"].ToString());
                    lsd.Add(sd);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lsd;
        }
    }
}
