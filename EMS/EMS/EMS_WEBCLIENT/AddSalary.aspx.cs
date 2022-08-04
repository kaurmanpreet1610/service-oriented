using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HospitalWebClient.SalaryService;

namespace HospitalWebClient
{
    public partial class AddSalary : System.Web.UI.Page
    {
        SalaryService.SalaryServiceClient client = new SalaryService.SalaryServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            SalaryDetails sd = new SalaryDetails();
            
            sd.Id = Convert.ToInt32(id.Text);
            sd.Salary = Convert.ToInt32(salary.Text);

            string msg = client.InsertSalaryDetails(sd);
            errmsg.Text = msg.ToString();

            Response.Redirect("~/AllSalary");
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            SalaryDetails sd = new SalaryDetails();
            sd.Id = Convert.ToInt32(id.Text);
            sd.Salary = Convert.ToInt32(salary.Text);

            bool msg = client.UpdateSalary(sd);
            if(!msg)
            {
                errmsg.Text = "Error updating!";
            }
            Response.Redirect("~/AllSalary");
        }
    }
}