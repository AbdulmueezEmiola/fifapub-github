using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
namespace Fifapub.app_start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(null, "", "~/Pages/HomePage.aspx",true);
            routes.MapPageRoute("home", "home", "~/Pages/HomePage.aspx",true);
            routes.MapPageRoute("gallery", "gallery", "~/Pages/Gallery.aspx",true);
            routes.MapPageRoute("Registration", "Registration", "~/Pages/Registration.aspx",true);
            routes.MapPageRoute("Winners", "Winners", "~/Pages/Winners.aspx",true);
            routes.MapPageRoute("News", "News", "~/Pages/News.aspx", true);
            routes.MapPageRoute("admin/news", "admin/news", "~/Pages/Admin/News.aspx", true);
            routes.MapPageRoute("admin/Gallery", "admin/Gallery", "~/Pages/Admin/GalleryAdmin.aspx", true);
            routes.MapPageRoute("admin/Winner", "admin/Winner", "~/Pages/Admin/WinnerAdmin.aspx", true);

        }
    }
}