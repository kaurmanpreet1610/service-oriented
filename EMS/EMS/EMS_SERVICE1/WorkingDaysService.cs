using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService1
{
    public class WorkingDaysService : IWorkingDaysService
    {
        static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @"D:\PROJECTS\Charanjit S\SOA design\Employee Management System\EMS\HostHospital\HPDB.mdf" + @";Integrated Security=True";//ConfigurationManager.ConnectionStrings["EMS_DB"].ConnectionString;
        SqlConnection con = new SqlConnection(connString);

        public bool DeleteWD(int ID)
        {
            con.Open();
            string query = "Delete from WorkingDays where id = @ID";
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

        public string deleteWD(deleteWD wd)
        {
            string msg;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete WorkingDays where d_id = @did", con);
            cmd.Parameters.AddWithValue("@did", wd.d_id);
            int g = cmd.ExecuteNonQuery();
            if (g == 1)
            {
                msg = "WorkingDays Deleted Successfully!";
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
            string query = "select * from WorkingDays where id = @ID";
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

        public List<WorkingDaysDetails> GetAllWD()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from WorkingDays", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<WorkingDaysDetails> DepartmentList = new List<WorkingDaysDetails>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    WorkingDaysDetails wd = new WorkingDaysDetails();
                    wd.Id = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                    wd.NumberOfWD = Convert.ToInt32((dt.Rows[i]["numberOfWD"].ToString()));
                    wd.ShiftDetails = dt.Rows[i]["shiftDetails"].ToString();
                    

                    DepartmentList.Add(wd);
                }
            }
            con.Close();
            return DepartmentList;
        }

        public List<WorkingDaysDetails> GetWDByID(int ID)
        {
            List<WorkingDaysDetails> wdList = new List<WorkingDaysDetails>();
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from WorkingDays where id = @ID", con);
                cmd.Parameters.AddWithValue("@ID", ID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        WorkingDaysDetails wd = new WorkingDaysDetails();
                        wd.Id = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                        wd.NumberOfWD = Convert.ToInt32((dt.Rows[i]["numberOfWD"].ToString()));
                        wd.ShiftDetails = dt.Rows[i]["shiftDetails"].ToString();

                        wdList.Add(wd);
                    }
                }
                con.Close();
            }
            return wdList;
        }

        public List<WorkingDaysDetails> GetWDDetails(int wdID)
        {
            List<WorkingDaysDetails> wdList = new List<WorkingDaysDetails>();

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from WorkingDays where id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", wdID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    WorkingDaysDetails wd = new WorkingDaysDetails();
                    wd.Id = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                    wd.NumberOfWD = Convert.ToInt32((dt.Rows[i]["numberOfWD"].ToString()));
                    wd.ShiftDetails = dt.Rows[i]["shiftDetails"].ToString();

                    wdList.Add(wd);
                }
            }
            con.Close();
            return wdList;
        }

        public string InsertWDDetails(WorkingDaysDetails wd)
        {
            string strMessage = string.Empty;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into WorkingDays(id,numberOfWD,shiftDetails) values(@id,@numberOfWD,@shiftDetails)", con);
            cmd.Parameters.AddWithValue("@id", wd.Id);
            cmd.Parameters.AddWithValue("@numberOfWD", wd.NumberOfWD);
            cmd.Parameters.AddWithValue("@shiftDetails", wd.ShiftDetails);

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                strMessage = wd.ShiftDetails + " inserted successfully";
            }
            else
            {
                strMessage = wd.ShiftDetails + " not inserted successfully";
            }
            con.Close();
            return strMessage;
        }

        public bool UpdateWD(WorkingDaysDetails wd)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Workingdays SET numberOfWD = @NumberOfWD, shiftDetails = @ShiftDetails WHERE id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", wd.Id);
            cmd.Parameters.AddWithValue("@NumberOfWD", wd.NumberOfWD);
            cmd.Parameters.AddWithValue("@ShiftDetails", wd.ShiftDetails);

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

        public getAllWD getWDs()
        {
            getAllWD gwd = new getAllWD();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from WorkingDays", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("MyTable");
            da.Fill(dt);
            gwd.allWds = dt;
            con.Close();
            return (gwd);
        }
    }
}
