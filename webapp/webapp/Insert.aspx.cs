using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;


namespace webapp
{
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Addlayer ai = new Addlayer();
            int Id = int.Parse(TextBox1.Text);
            string Sname = TextBox2.Text;
            string Scourse = TextBox3.Text;
            string Doj = TextBox4.Text;
            ai.DInsert(Id,Sname,Scourse,Doj);
        }
    }
}