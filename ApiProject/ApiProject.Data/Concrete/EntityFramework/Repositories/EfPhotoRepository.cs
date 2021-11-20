using ApiProject.Core.Data.Concrete.EntityFramework;
using ApiProject.Data.Abstract;
using ApiProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Data.Concrete.EntityFramework.Repositories
{
    public class EfPhotoRepository : EfEntityRepositoryBase<Photo>, IPhotoRepository
    {
        public EfPhotoRepository(DbContext context) : base(context)
        {
        }
    }
}
