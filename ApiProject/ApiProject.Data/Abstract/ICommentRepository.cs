using ApiProject.Core.Data.Abstract;
using ApiProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Data.Abstract
{
    public interface ICommentRepository : IEntityRepository<Comment>
    {
    }
}
