using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webapp
{
    public partial class Webstudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Addlayer ad1 = new Addlayer();
            int idno = Convert.ToInt32(TextBox1.Text);
            var singlestudent = ad1.Getstudent(idno);
            GridView1.DataSource = singlestudent;
            GridView1.DataBind();
        }
    }
}