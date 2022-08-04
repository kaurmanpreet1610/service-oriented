using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HospitalWebClient
{
    public partial class AllSalary : System.Web.UI.Page
    {
        SalaryService.SalaryServiceClient client = new SalaryService.SalaryServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
  
        }

        protected void btnview_Click(object sender, EventArgs e)
        {
            SalaryService.getAllSalary g = new SalaryService.getAllSalary();
            g = client.getSalaries();
            DataTable d = new DataTable();
            d = g.allSalaries;
            
            gridview.DataSource = d;
            gridview.DataBind();
        }
    }
}