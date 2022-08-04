using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService1
{
    public class SalaryService : ISalaryService
    {
        static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @"D:\PROJECTS\Charanjit S\SOA design\Employee Management System\EMS\HostHospital\HPDB.mdf" + @";Integrated Security=True";//ConfigurationManager.ConnectionStrings["EMS_DB"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);

        

      
        public bool FindById(int id)
        {
            con.Open();
            string query = "select * from Salary where id = @ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", id);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            if (res == 1)
            {
                return true;
            }
            else { return false; }
        }

        public List<SalaryDetails> GetAllSalary()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Salary", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<SalaryDetails> list = new List<SalaryDetails>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SalaryDetails sd = new SalaryDetails();
                    sd.Id = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                    sd.Salary = Convert.ToInt32(dt.Rows[i]["Salary"].ToString());

                    list.Add(sd);
                }
            }
            con.Close();
            return list;
        }

        public List<SalaryDetails> GetSalaryDetailsByID(int ID)
        {
            List<SalaryDetails> depList = new List<SalaryDetails>();
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Salary where id = @ID", con);
                cmd.Parameters.AddWithValue("@ID", ID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        SalaryDetails sd = new SalaryDetails();
                        sd.Id = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                        sd.Salary = Convert.ToInt32(dt.Rows[i]["Salary"].ToString());

                        depList.Add(sd);
                    }
                }
                con.Close();
            }
            return depList;
        }

        public List<SalaryDetails> GetSalaryDetails(int sID)
        {
            List<SalaryDetails> list = new List<SalaryDetails>();

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Salary where id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", sID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SalaryDetails sd = new SalaryDetails();
                    sd.Id = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                    sd.Salary = Convert.ToInt32(dt.Rows[i]["Salary"].ToString());

                    list.Add(sd);
                }
            }
            con.Close();
            return list;
        }

        public string InsertSalaryDetails(SalaryDetails sd)
        {
            string strMessage = string.Empty;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Salary(id,salary) values(@id,@salary)", con);
            cmd.Parameters.AddWithValue("@id", sd.Id);
            cmd.Parameters.AddWithValue("@salary", sd.Salary);

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                strMessage = sd.Salary + " inserted successfully";
            }
            else
            {
                strMessage = sd.Salary + " not inserted successfully";
            }
            con.Close();
            return strMessage;
        }

        public bool UpdateSalary(SalaryDetails sd)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Salary SET salary = @Salary WHERE id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", sd.Id);
            cmd.Parameters.AddWithValue("@Salary", sd.Salary);


            int res = cmd.ExecuteNonQuery();
            con.Close();
            if (res == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public getAllSalary getSalaries()
        {
            getAllSalary gas = new getAllSalary();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Salary", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("MyTable");
            da.Fill(dt);
            gas.allSalaries = dt;
            con.Close();
            return (gas);
        }
    }
}
