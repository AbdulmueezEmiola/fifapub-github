using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fifapub.Presenters;
using Fifapub.Models.Repository;
using Fifapub.Models;
using Fifapub.Presenters.Result;
using System.Web.ModelBinding;
using System.IO;
using System.Web.Routing;

namespace Fifapub.Pages.Admin
{
    public partial class GalleryAdmin1 : System.Web.UI.Page
    {
        public IPresenters<Models.Gallery> presenters { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {           
            presenters = new GalleryPresenter
            {
                repository = new MemoryRepository()
            };
            if (IsPostBack)
            {
                int count = FileUpload1.PostedFiles.Count;
                Models.Gallery[] galleries = new Models.Gallery[count];
                for (int i = 0; i < count; ++i)
                {
                    int number = presenters.Count() + i;
                    string fileName = "~/Images/Galleries/" + number + ".jpeg";
                    FileUpload1.PostedFiles[i].SaveAs(Server.MapPath(fileName));
                    galleries[i] = new Models.Gallery();
                    galleries[i].image = Server.MapPath(fileName);
                }
                Response.Redirect(((RedirectResult)presenters.GetResult(galleries)).Url);
            }
        }
        protected string CreatePageLink(string value)
        {
            string path = RouteTable.Routes.GetVirtualPath(null, value, null).VirtualPath;
            return path;
        }
    }
}