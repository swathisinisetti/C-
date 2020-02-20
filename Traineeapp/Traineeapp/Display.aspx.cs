using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traineeapp
{
    public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                TraineeDataLayer t = new TraineeDataLayer();
                var list = t.getallrecords();
                GridView1.DataSource = list;
                GridView1.DataBind();
            }
        }

       

        protected void Button1_Click1(object sender, EventArgs e)
        {
            


        }
    }
}