using ApiProject.Core.Utilities.Results.Abstract;
using ApiProject.Entities.Dtos;
using ApiProject.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Services.Concrete
{
    public class PhotoManager : IPhotoService
    {
        public Task<IResult> Add(PhotoAddDto photoAddDto, string createdByName)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int photoId, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PhotoDto>> Get(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PhotoListDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PhotoListDto>> GetAllByNonDeleted()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PhotoListDto>> GetAllByNonDeletedAndActive()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDelete(int photoId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(PhotoUpdateDto photoUpdateDto, string modifiedByName)
        {
            throw new NotImplementedException();
        }
    }
}
