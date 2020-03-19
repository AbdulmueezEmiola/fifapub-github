using Fifapub.Models.Repository;
using Fifapub.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fifapub.Pages
{
    public partial class News : System.Web.UI.Page
    {
        public IPresenters<Models.New> presenters { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IEnumerable<Models.New> GetNews()
        {
            presenters = new NewsPresenter
            {
                repository = new MemoryRepository()
            };
            IEnumerable<Models.New> repo = presenters.GetAll();
            return repo;
        }
        public string MapURL(string path)
        {
            string appPath = Server.MapPath("/").ToLower();
            return string.Format("/{0}", path.ToLower().Replace(appPath, "").Replace(@"\", "/"));
        }
        protected string CreatePageLink(string value)
        {
            string path = RouteTable.Routes.GetVirtualPath(null, value, null).VirtualPath;
            return path;
        }
    }
}