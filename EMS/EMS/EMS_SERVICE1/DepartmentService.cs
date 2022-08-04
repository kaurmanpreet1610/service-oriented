using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService1
{
    public class DepartmentService : IDepartmentService
    {
        static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @"D:\PROJECTS\Charanjit S\SOA design\Employee Management System\EMS\HostHospital\HPDB.mdf" + @";Integrated Security=True";//ConfigurationManager.ConnectionStrings["EMS_DB"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);

        public bool DeleteDepartment(int ID)
        {
            con.Open();
            string query = "Delete from Department where id = @ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);
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

        public string deleteDepartment(deleteDepartment dd)
        {
            string msg;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Department where d_id = @did", con);
            cmd.Parameters.AddWithValue("@did", dd.d_id);
            int g = cmd.ExecuteNonQuery();
            if (g == 1)
            {
                msg = "Department Deleted Successfully!";
            }
            else
            {
                msg = "Failed to Delete!";
            }
            return (msg);
        }

        public bool FindById(int id)
        {
            con.Open();
            string query = "select * from Department where id = @ID";
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

        public List<DepartmentDetails> GetAllDepartments()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Department", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<DepartmentDetails> DepartmentList = new List<DepartmentDetails>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DepartmentDetails depInfo = new DepartmentDetails();
                    depInfo.Id = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                    depInfo.Name = dt.Rows[i]["name"].ToString();

                    DepartmentList.Add(depInfo);
                }
            }
            con.Close();
            return DepartmentList;
        }

        public List<DepartmentDetails> GetDepartmentDetailsByID(int ID)
        {
            List<DepartmentDetails> depList = new List<DepartmentDetails>();
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Department where id = @ID", con);
                cmd.Parameters.AddWithValue("@ID", ID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DepartmentDetails depID = new DepartmentDetails();
                        depID.Id = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                        depID.Name = dt.Rows[i]["name"].ToString();

                        depList.Add(depID);
                    }
                }
                con.Close();
            }
            return depList;
        }

        public List<DepartmentDetails> GetDepartmentDetails(int depID)
        {
            List<DepartmentDetails> depList = new List<DepartmentDetails>();

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Department where id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", depID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DepartmentDetails depInfo = new DepartmentDetails();
                    depInfo.Id = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                    depInfo.Name = dt.Rows[i]["name"].ToString();

                    depList.Add(depInfo);
                }
            }
            con.Close();
            return depList;
        }

        public string InsertDepartmentDetails(DepartmentDetails depInfo)
        {
            string strMessage = string.Empty;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Department(id,name) values(@id,@name)", con);
            cmd.Parameters.AddWithValue("@id", depInfo.Id);
            cmd.Parameters.AddWithValue("@name", depInfo.Name);

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                strMessage = depInfo.Name + " inserted successfully";
            }
            else
            {
                strMessage = depInfo.Name + " not inserted successfully";
            }
            con.Close();
            return strMessage;
        }

        public bool UpdateDepartment(DepartmentDetails depInfo)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Department SET name = @Name WHERE id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", depInfo.Id);
            cmd.Parameters.AddWithValue("@Name", depInfo.Name);


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

        public getAllDepartments getDepartments()
        {
            getAllDepartments gd = new getAllDepartments();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Department", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("MyTable");
            da.Fill(dt);
            gd.allDepartments = dt;
            con.Close();
            return (gd);
        }
    }
}
