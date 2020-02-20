using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspcontrols
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            string data = "";
            string name = txtname.Text;
            string dob = Calendar1.SelectedDate.ToString();
            string gender = RadioButtonList1.SelectedItem.Value.ToString();
            string Hobby = "";
            if (CheckBoxList1.Items[0].Selected)
            {
                Hobby += "\n" + CheckBoxList1.Items[0].Value;
            }
            if (CheckBoxList1.Items[1].Selected)
            {
                Hobby += "\n" + CheckBoxList1.Items[1].Value;
            }
            if (CheckBoxList1.Items[2].Selected)
            {
                Hobby += "\n" + CheckBoxList1.Items[2].Value;
            }
            string education = TextBox1.Text;
            data += name + "\n" + gender + Hobby + "\n" + education;
            Label6.Text = data;





        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            



        }
    }
}