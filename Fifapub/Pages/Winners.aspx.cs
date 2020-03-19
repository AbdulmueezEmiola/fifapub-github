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
    public partial class Winners : System.Web.UI.Page
    {
        public IPresenters<Models.Winner> presenters { get; set; }
        public IPresenters<Models.Event> eventPresenters { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IEnumerable<Models.Winner> GetWinners()
        {
            presenters = new WinnerPresenter
            {
                repository = new MemoryRepository()
            };
            IEnumerable<Models.Winner> repo = presenters.GetAll().Where(e=>e.fifa==true);
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
        public int GetMaxWinnerInputed()
        {
            presenters = new WinnerPresenter
            {
                repository = new MemoryRepository()
            };
            return presenters.GetAll().Max(e => e.EventId);            
        }
        public string MapURL(string path)
        {
            string appPath = Server.MapPath("/").ToLower();
            return string.Format("/{0}", path.ToLower().Replace(appPath, "").Replace(@"\", "/"));
        }
        public string getFifaWinnerImage(int eventId)
        {
            IEnumerable<Models.Winner> winners = GetWinners().Where(e=>e.EventId==eventId).Where(e=>e.fifa==true);
            if(!winners.Any())
            {
                return "/Images/Winner1.jpeg";
            }
            else
            {
                return winners.Last().Image;
            }
        }
        public string getFifaWinnerName(int eventId)
        {
            IEnumerable<Models.Winner> winners = GetWinners().Where(e => e.EventId == eventId).Where(e => e.fifa == true);
            if (!winners.Any())
            {
                return "Not Updated Yet";
            }
            else
            {
                return winners.Last().Name;
            }
        }
        public string getPUBGWinnerImage(int eventId)
        {
            IEnumerable<Models.Winner> winners = GetWinners().Where(e => e.EventId == eventId).Where(e => e.pubg == true);
            if (!winners.Any())
            {
                return "Not Updated Yet";
            }
            else
            {
                return winners.Last().Image;
            }
        }
        public string getPUBGWinnerName(int eventId)
        {
            IEnumerable<Models.Winner> winners = GetWinners().Where(e => e.EventId == eventId).Where(e => e.pubg == true);
            if (!winners.Any())
            {
                return "Not Updated Yet";
            }
            else
            {
                return winners.Last().Name;
            }
        }
        protected string CreatePageLink(string value)
        {
            string path = RouteTable.Routes.GetVirtualPath(null, value, null).VirtualPath;
            return path;
        }
    }
}