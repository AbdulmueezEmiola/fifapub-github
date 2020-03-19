using Fifapub.Models;
using Fifapub.Presenters.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fifapub.Models.Repository;
namespace Fifapub.Presenters
{
    public class GalleryPresenter : IPresenters<Gallery>
    {
        public IRepository repository
        {
            get;
            set;
        }
        public int Count()
        {
            return repository.GetGalleries().Count();
        }

        public IEnumerable<Gallery> GetAll()
        {
            return repository.GetGalleries();
        }

        public IResult GetResult()
        {
            return new DataResult<Gallery>(new Gallery());
        }

        public IResult GetResult(Gallery []requestData)
        {
            for(int i = 0; i < requestData.Length; ++i) {
                repository.addGallery(requestData[i]);
            }
            return new RedirectResult("~/Pages/HomePage.aspx");
        }

        public IResult GetResult(Gallery requestData)
        {
            throw new NotImplementedException();
        }
    }
}