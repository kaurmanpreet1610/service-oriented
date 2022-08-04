using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HospitalWebClient.DepartmentService;

namespace HospitalWebClient
{
    public partial class AddDepartment : System.Web.UI.Page
    {
        DepartmentService.DepartmentServiceClient client = new DepartmentService.DepartmentServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            DepartmentDetails dep = new DepartmentDetails();
            dep.Name = name.Text;
            dep.Id = Convert.ToInt32(id.Text);

            string msg = client.InsertDepartmentDetails(dep);
            errmsg.Text = msg.ToString();

            Response.Redirect("~/AllDepartment");
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            DepartmentDetails dep = new DepartmentDetails();
            dep.Name = name.Text;
            dep.Id = Convert.ToInt32(id.Text);

            bool msg = client.UpdateDepartment(dep);
            if(!msg)
            {
                errmsg.Text = "Error updating!";
            }
            Response.Redirect("~/AllDepartment");
        }
    }
}