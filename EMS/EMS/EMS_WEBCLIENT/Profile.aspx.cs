using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace HospitalWebClient
{
    public partial class Profile : System.Web.UI.Page
    {
        EmployeeRegistrationService.EmployeeregistrationPortTypeClient client = new EmployeeRegistrationService.EmployeeregistrationPortTypeClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnprupdate_Click(object sender, EventArgs e)
        {
            if (pass1.Text == pass2.Text)
            {
                int id = Convert.ToInt32(Session["userID"].ToString());
                int resp = client.edit(id, uname.Text, pass1.Text);

                if (resp > 0)
                {
                    Session["curruser"] = uname.Text;
                }
            }
        }
    }
}