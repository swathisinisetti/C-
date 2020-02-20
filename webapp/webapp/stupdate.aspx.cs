using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace webapp
{
    public partial class stupdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Addlayer ad1 = new Addlayer();
            DateTime Doj =DateTime.Parse(TextBox1.Text);
            string Sname = TextBox2.Text;
            
           var up = ad1.update(Doj,Sname);
            GridView1.DataSource = up;
            GridView1.Dispose();

        }

    }
    }
