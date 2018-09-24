using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TYPES;
using FactoryBO;
using FACTORYBLL;

namespace FactoryExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            IEMPLBO objBO = EMPFACTORYBO.CheckEmployees(username, password);
            IEMPLBLL objBLL = EMPFACTORYBLL.Createnew();
            int check = objBLL.CheckEmp(objBO);
            if(check==1)
            {
                lblMessage.Text = "Welcome Back " + username;
            }

            else
            {
                lblMessage.Text = "Who the hell are you?";
            }

        }
    }
}