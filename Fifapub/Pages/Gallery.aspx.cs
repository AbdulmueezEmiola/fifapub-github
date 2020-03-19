using Fifapub.Models.Repository;
using Fifapub.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fifapub.Pages
{
    public partial class Gallery1 : System.Web.UI.Page
    {
        public IPresenters<Models.Gallery> presenters { get; set; }

        public IPresenters<Models.Event> eventPresenters { get; set; }

        public IEnumerable<Models.Gallery> GetGallery([Control("ItemId")] int itemId)
        {            
            presenters = new GalleryPresenter
            {
                repository = new MemoryRepository()
            };
            IEnumerable<Models.Gallery> repo = presenters.GetAll().Where(e => e.EventId == itemId);
            return repo;
        }
        public IEnumerable<Models.Event> GetEvent()
        {
            eventPresenters = new EventPresenter
            {
                repository = new MemoryRepository()
            };
            IEnumerable<Models.Event> repo = eventPresenters.GetAll();
            return repo;
        }        
        public string MapURL(string path)
        {
            string appPath = Server.MapPath("/").ToLower();
            return string.Format("/{0}", path.ToLower().Replace(appPath, "").Replace(@"\", "/"));
        }
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