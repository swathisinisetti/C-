using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traineeapp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            TraineeDataLayer t = new TraineeDataLayer();
            Trainee1 t1 = new Trainee1 {

             tid = int.Parse(TextBox1.Text),
             tname = TextBox2.Text,
            location = TextBox3.Text,
            techdomain = TextBox4.Text,
             startdate = DateTime.Parse(TextBox5.Text)
        };
            t.DInsert(t1);
        }
    }
}