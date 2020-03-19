using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fifapub.Pages
{
    public partial class PaymentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected string CreatePageLink(string value)
        {
            string path = RouteTable.Routes.GetVirtualPath(null, value, null).VirtualPath;
            return path;
        }
    }
}