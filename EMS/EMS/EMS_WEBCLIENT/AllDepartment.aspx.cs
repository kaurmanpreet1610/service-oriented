using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HospitalWebClient
{
    public partial class AllDepartment : System.Web.UI.Page
    {
        DepartmentService.DepartmentServiceClient client = new DepartmentService.DepartmentServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
  
        }

        protected void btnview_Click(object sender, EventArgs e)
        {
            //HospitalService1.getAllDoctors g = new HospitalService1.getAllDoctors();
            DepartmentService.getAllDepartments g = new DepartmentService.getAllDepartments();
            g = client.getDepartments();
            DataTable d = new DataTable();
            d = g.allDepartments;
            
            gridview.DataSource = d;
            gridview.DataBind();
        }
    }
}