using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HospitalWebClient
{
    public partial class AllWD : System.Web.UI.Page
    {
        WorkingDaysService.WorkingDaysServiceClient client = new WorkingDaysService.WorkingDaysServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
  
        }

        protected void btnview_Click(object sender, EventArgs e)
        {
            WorkingDaysService.getAllWD g = new WorkingDaysService.getAllWD();
            g = client.getWDs();
            DataTable d = new DataTable();
            d = g.allWds;
            
            gridview.DataSource = d;
            gridview.DataBind();
        }
    }
}