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
    public partial class WebForm1 : System.Web.UI.Page
    {
        public IPresenters<New> presenters { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            presenters = new NewsPresenter
            {
                repository = new MemoryRepository()
            };
            if (IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {            
                    New news = ((DataResult<New>)presenters.GetResult()).DataItem;
                    if (TryUpdateModel(news, new FormValueProvider(ModelBindingExecutionContext)))
                    {

                        string fileName = "~/Images/News/" + presenters.Count() + ".jpeg";
                        File1.PostedFile.SaveAs(Server.MapPath(fileName));
                        news.Image = Server.MapPath(fileName);
                        news.Date = DateTime.Now;
                        Response.Redirect(((RedirectResult)presenters.GetResult(news)).Url);
                    }
                }
            }
        }
        protected string CreatePageLink(string value)
        {
            string path = RouteTable.Routes.GetVirtualPath(null, value, null).VirtualPath;
            return path;
        }
    }
}