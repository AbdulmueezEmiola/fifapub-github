﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
namespace Fifapub.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string name = Request.Form["userName"];
                string password = Request.Form["password"];
                if(name != null &password !=null && FormsAuthentication.Authenticate(name, password))
                {
                    FormsAuthentication.SetAuthCookie(name, false);
                    Response.Redirect(Request["ReturnUrl"] ?? "/");
                }
                else
                {
                    ModelState.AddModelError("fail", "Login failed. Please try again");
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