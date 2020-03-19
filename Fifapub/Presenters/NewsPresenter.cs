using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fifapub.Models;
using Fifapub.Presenters.Result;
using Fifapub.Models.Repository;
namespace Fifapub.Presenters
{
    public class NewsPresenter : IPresenters<New>
    {
        public IRepository repository
        {
            get;
            set;
        }
        public IResult GetResult()
        {
            return new DataResult<New>(new New());
        }

        public IResult GetResult(New requestData)
        {
            repository.addNews(requestData);
            return new RedirectResult("~/Pages/HomePage.aspx");
        }
        public int Count()
        {
            return repository.GetNews().Count();
        }

        public IResult GetResult(New[] requestData)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<New> GetAll()
        {
            return repository.GetNews();
        }
    }
}