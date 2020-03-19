using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fifapub.Models;
using Fifapub.Presenters.Result;
using Fifapub.Models.Repository;
namespace Fifapub.Presenters
{
    public class RegistrationPresenter : IPresenters<Registration>
    {
        public IRepository repository
        {
            get;
            set;
        }
        public IResult GetResult()
        {
            return new DataResult<Registration>(new Registration());
        }

        public IResult GetResult(Registration requestData)
        {
            repository.addRegistration(requestData);
            return new RedirectResult("~/Pages/HomePage.aspx");
        }

        public int Count()
        {
            return repository.GetRegistrations().Count();
        }

        public IResult GetResult(Registration[] requestData)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Registration> GetAll()
        {
            return repository.GetRegistrations();
        }
    }
}