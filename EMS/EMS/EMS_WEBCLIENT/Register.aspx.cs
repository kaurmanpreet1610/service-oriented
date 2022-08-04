using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace HospitalWebClient
{
    public partial class Register : System.Web.UI.Page
    {
        EmployeeRegistrationService.EmployeeregistrationPortTypeClient client = new EmployeeRegistrationService.EmployeeregistrationPortTypeClient();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnregister_Click(object sender, EventArgs e)
        {
            
            if (pass.Text == pass2.Text)
            {
                int resp = client.register(username.Text, pass.Text);
                Response.Redirect("EmployeeLogin");
            }
            else
            {
                string msg = "Password Doesn't Match!";
                errreg.Text = msg.ToString();
            }
        }
    }
}