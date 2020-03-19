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
using System.Web.Routing;

namespace Fifapub.Pages.Admin
{
    public partial class WinnerAdmin1 : System.Web.UI.Page
    {
        public IPresenters<Winner> presenters { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            presenters = new WinnerPresenter
            {
                repository = new MemoryRepository()
            };
            if (IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    Winner winner = ((DataResult<Winner>)presenters.GetResult()).DataItem;
                    string fileName = "~/Images/Winner/" + presenters.Count() + ".jpeg";
                    image.PostedFile.SaveAs(Server.MapPath(fileName));
                    if (TryUpdateModel(winner, new FormValueProvider(ModelBindingExecutionContext)))
                    {
                        winner.fifa = fifa.Checked;
                        winner.pubg = pubg.Checked;
                        winner.Image = Server.MapPath(fileName);
                        Response.Redirect(((RedirectResult)presenters.GetResult(winner)).Url);
                    }
                }                
            }
        }
        protected void RadioButtonServerCheck(object sender, ServerValidateEventArgs e)
        {
            if (!pubg.Checked && !fifa.Checked )
            {
                e.IsValid = false;
                ((CustomValidator)sender).ErrorMessage = @"You must pick at least one event";
            }else if(image.PostedFile.ContentLength == 0)
            {
                e.IsValid = false;
                ((CustomValidator)sender).ErrorMessage = @"You must upload an image";
            }
            else
            {
                e.IsValid = true;
            }
        }
        protected string CreatePageLink(string value)
        {
            string path = RouteTable.Routes.GetVirtualPath(null, value, null).VirtualPath;
            return path;
        }
    }
}