using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;

namespace aspimageupload
{
    public partial class WebForm2 : System.Web.UI.Page
    {
       
            void Page_PreRender()
            {
                string uploadfolder = MapPath("~/images/");
                DirectoryInfo dir = new DirectoryInfo(uploadfolder);
                DataList1.DataSource = dir.GetFiles();
                DataList1.DataBind();
            }
           



        protected void Page_Load(object sender, EventArgs e)
        {

        }
            bool CheckFileType(string filename)
            {
                string ext = Path.GetExtension(filename);
                switch (ext.ToLower())
                {
                    case ".gid":
                        return true;
                    case ".png":
                        return true;
                    case ".jpg":
                        return true;
                    case ".jpeg":
                    default:
                        return true;
                }
            }

        protected void Button1_click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFiles)
            {
                if (CheckFileType(FileUpload1.FileName))
                {
                    FileUpload1.SaveAs(MapPath("~/images/") + FileUpload1.FileName);
                }

            }

        }
    }
    }
