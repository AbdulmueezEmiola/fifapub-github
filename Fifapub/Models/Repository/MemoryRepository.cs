using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fifapub.Models.Repository
{
    public class MemoryRepository:IRepository
    {
        private EFDBContext context = new EFDBContext();
        private int getCurrentEvent()
        {
            return context.Events.Max(key => key.EventId);
        }
        public void addRegistration(Registration registration)
        {
            if (registration != null)
            {
                registration.EventId = getCurrentEvent();
                registration = context.Registrations.Add(registration);
                context.SaveChanges();
            }
        }
        public void addNews(New news)
        {
            news = context.News.Add(news);
            context.SaveChanges();
        }
        public IEnumerable<New> GetNews()
        {
            return context.News;
        }
        public IEnumerable<Registration> GetRegistrations()
        {
            return context.Registrations;
        }

        public void addWinner(Winner winner)
        {
            if (winner != null)
            {
                winner.EventId = getCurrentEvent();
                winner = context.Winners.Add(winner);
                context.SaveChanges();
            }            
        }

        public IEnumerable<Winner> GetWinners()
        {
            return context.Winners;
        }

        public IEnumerable<Gallery> GetGalleries()
        {
            return context.Galleries;
        }

        public void addGallery(Gallery gallery)
        {
            if (gallery != null)
            {
                gallery.EventId = getCurrentEvent();
                gallery = context.Galleries.Add(gallery);
                context.SaveChanges();
            }
        }
        public IEnumerable<Event> GetEvents()
        {
            return context.Events;
        }

        
    }
}