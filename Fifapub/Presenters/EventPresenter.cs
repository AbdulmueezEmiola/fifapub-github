using Fifapub.Models;
using Fifapub.Models.Repository;
using Fifapub.Presenters.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fifapub.Presenters
{
    public class EventPresenter : IPresenters<Event>
    {
        public IRepository repository
        {
            get;
            set;
        }
        public IResult GetResult()
        {
            return new DataResult<Event>(new Event());
        }

        public IResult GetResult(Event requestData)
        {
            throw new NotImplementedException();

        }
        public int Count()
        {
            return repository.GetEvents().Count();
        }

        public IResult GetResult(Event[] requestData)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Event> GetAll()
        {
            return repository.GetEvents();
        }
    }
}