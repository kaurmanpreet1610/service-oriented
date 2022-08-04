using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HospitalWebClient.WorkingDaysService;

namespace HospitalWebClient
{
    public partial class AddWD : System.Web.UI.Page
    {
        WorkingDaysService.WorkingDaysServiceClient client = new WorkingDaysService.WorkingDaysServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            WorkingDaysDetails wdd = new WorkingDaysDetails();
            wdd.NumberOfWD = Convert.ToInt32(wdnum.Text);
            wdd.Id = Convert.ToInt32(id.Text);
            wdd.ShiftDetails = shift.Text;

            string msg = client.InsertWDDetails(wdd);
            errmsg.Text = msg.ToString();

            Response.Redirect("~/AllWD");
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            WorkingDaysDetails wdd = new WorkingDaysDetails();
            wdd.NumberOfWD = Convert.ToInt32(wdnum.Text);
            wdd.Id = Convert.ToInt32(id.Text);
            wdd.ShiftDetails = shift.Text;

            bool msg = client.UpdateWD(wdd);
            if(!msg)
            {
                errmsg.Text = "Error updating!";
            }
            Response.Redirect("~/AllWD");
        }
    }
}