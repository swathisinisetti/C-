using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace webapp
{
    public partial class ss : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Addlayer a = new Addlayer();
                var strlist = a.getallrecords();
            GridView1.DataSource = strlist;
                GridView1.DataBind();

                var str = a.Insert();
                GridView1.DataSource = str;

                
               

            }
        }
        public static void getdata()
        {

        }
    }
}
