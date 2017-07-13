using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyRESTService
{
    public partial class form : System.Web.UI.Page
    {
        Service1 svc;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (svc == null) {
                svc = new Service1();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = svc.GetTeste();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            svc.SetTeste(TextBox1.Text);
        }
    }
}