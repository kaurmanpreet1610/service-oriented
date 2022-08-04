using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HospitalWebClient.DepartmentService;

namespace HospitalWebClient
{
    public partial class DeleteDepartment : System.Web.UI.Page
    {
        DepartmentService.DepartmentServiceClient client = new DepartmentService.DepartmentServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            bool msg = client.DeleteDepartment(int.Parse(depid.Text));
            //deleteDepartment dd = new deleteDepartment();
            //dd.d_id = int.Parse(depid.Text);
            //string msg = client.deleteDepartment1(dd);
            if(msg)
                errdelete.Text = "Department Deleted!";
            else
                errdelete.Text = "Error deleting department!";

            Response.Redirect("Default");
        }
    }
}