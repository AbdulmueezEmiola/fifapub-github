using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fifapub.Models.Repository;
using Fifapub.Presenters;
namespace Fifapub.Pages
{
    public partial class HomePage : System.Web.UI.Page
    {
        public IPresenters<Models.Gallery> presenters { get; set; }
        public IPresenters<Models.Winner> winnerPresenters { get; set; }
        public IPresenters<Models.New> newPresenters { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        public IEnumerable<Models.Gallery> GetGallery()
        {
            presenters = new GalleryPresenter
            {
                repository = new MemoryRepository()
            };
            IEnumerable<Models.Gallery> repo = presenters.GetAll().Take(3);
            return repo;
        }
        public IEnumerable<Models.Winner> GetWinner()
        {
            winnerPresenters = new WinnerPresenter
            {
                repository = new MemoryRepository()
            };
            IEnumerable<Models.Winner> repo = winnerPresenters.GetAll().Take(3);
            return repo;
        }
        public IEnumerable<Models.New> GetNews()
        {
            newPresenters = new NewsPresenter
            {
                repository = new MemoryRepository()
            };
            IEnumerable<Models.New> repo = newPresenters.GetAll().Take(3);
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