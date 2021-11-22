using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Core.Utilities.Results.Abstract
{
    // data result sayesinde resultlar icinde verileri de tasiyabiliyor olacaz
    // out T : veriyi hem tek basına hem de liste olarak ekleyebiliriz
    public interface IDataResult<out T> : IResult
    {
        public T Data { get; } // new DataResult<Category>(ResultStatus.Success,category);
                               // new DataResult<IList<Category>>(ResultStatus.Success, categoryList);
    }
}
