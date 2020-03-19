using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fifapub.Models;
using Fifapub.Presenters.Result;
using Fifapub.Models.Repository;

namespace Fifapub.Presenters
{
    public class WinnerPresenter : IPresenters<Winner>
    {
        public IRepository repository
        {
            get;
            set;
        }
        public int Count()
        {
            return repository.GetWinners().Count();
        }

        public IEnumerable<Winner> GetAll()
        {
            return repository.GetWinners(); 
        }

        public IResult GetResult()
        {
            return new DataResult<Winner>(new Winner());
        }

        public IResult GetResult(Winner requestData)
        {
            repository.addWinner(requestData);
            return new RedirectResult("~/Pages/HomePage.aspx");
        }

        public IResult GetResult(Winner[] requestData)
        {
            throw new NotImplementedException();
        }
    }
}