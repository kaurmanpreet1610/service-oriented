using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using HospitalWebClient.HospitalService1;

namespace HospitalWebClient
{
    public partial class PLogin : System.Web.UI.Page
    {
        EmployeeRegistrationService.EmployeeregistrationPortTypeClient client = new EmployeeRegistrationService.EmployeeregistrationPortTypeClient();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnplogin_Click(object sender, EventArgs e)
        {
            string useremail = uname.Text;
            string password = pass.Text;
            int res = client.login(useremail, password);
            if (res > 0)
            {
                Session["curruser"] = "employee";
                Session["userID"] = res;
                Response.Redirect("Default");
                //Session.RemoveAll();
            }
            else
            {
                errplogin.Text = "Invalid Credential!";
            }
        }
    }
}