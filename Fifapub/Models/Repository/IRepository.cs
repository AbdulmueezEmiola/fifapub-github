using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifapub.Models.Repository
{
    public interface IRepository
    {
        IEnumerable<Registration> GetRegistrations();
        void addRegistration(Registration registration);
        void addNews(New news);
        IEnumerable<New> GetNews();
        void addWinner(Winner winner);
        IEnumerable<Winner> GetWinners();
        IEnumerable<Gallery> GetGalleries();
        void addGallery(Gallery gallery);

        IEnumerable<Event> GetEvents();
    }
}
