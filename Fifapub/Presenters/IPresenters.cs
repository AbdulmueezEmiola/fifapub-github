using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fifapub.Presenters.Result;
namespace Fifapub.Presenters
{
    public interface IPresenters<T>
    {
        IResult GetResult();
        IResult GetResult(T requestData);
        int Count();
        IResult GetResult(T[] requestData);
        IEnumerable<T> GetAll();
    }
}
