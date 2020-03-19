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

namespace Fifapub.Pages
{
    public partial class Gallery : System.Web.UI.Page//named gallery due to a mistake
    {
        public IPresenters<Registration> presenters { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            presenters = new RegistrationPresenter
            {
                repository = new MemoryRepository()
            }; 
            if (IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    Registration registration = ((DataResult<Registration>)presenters.GetResult()).DataItem;
                    if (TryUpdateModel(registration, new FormValueProvider(ModelBindingExecutionContext)))
                    {
                        Response.Redirect(((RedirectResult)presenters.GetResult(registration)).Url);
                    }
                }
            }
        }
        protected void CheckBoxServerCheck(object sender, ServerValidateEventArgs e)
        {
            if(!pubg.Checked && !fifa.Checked )
            {
                e.IsValid = false;
                ((CustomValidator)sender).ErrorMessage = @"You must pick at least one event";
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