using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fifapub.Presenters.Result
{
    public class RedirectResult:IResult
    {
        private string url;
        public RedirectResult(String urlValue)
        {
            url = urlValue;
        }
        public String Url
        {
            get
            {
                return url;
            }
        }
    }
}