using ApiProject.Core.Utilities.Results.Abstract;
using ApiProject.Core.Utilities.Results.ComplexTypes;
using ApiProject.Core.Utilities.Results.Concrete;
using ApiProject.Data.Abstract;
using ApiProject.Entities.Concrete;
using ApiProject.Entities.Dtos;
using ApiProject.Services.Abstract;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Services.Concrete
{
    public class PhotoManager : IPhotoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PhotoManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IDataResult<PhotoDto>> Get(int photoId)
        {
            var photo = await _unitOfWork.Photos.GetAsync(p => p.Id == photoId, p => p.User);
            if (photo != null)
            {
                return new DataResult<PhotoDto>(ResultStatus.Success, new PhotoDto
                {
                    Photo = photo,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<PhotoDto>(ResultStatus.Error, "Böyle bir fotoğraf bulunamadı.", null);
        }

        public async Task<IDataResult<PhotoListDto>> GetAll()
        {
            var photos = await _unitOfWork.Photos.GetAllAsync(null, p => p.User);
            if (photos.Count > -1)
            {
                return new DataResult<PhotoListDto>(ResultStatus.Success, new PhotoListDto
                {
                    Photos = photos,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<PhotoListDto>(ResultStatus.Error, "Fotoğraflar bulunamadı.", null);
        }

        
        
        public async Task<IDataResult<PhotoListDto>> GetAllByNonDeleted()
        {
            var photos = await _unitOfWork.Photos.GetAllAsync(p => !p.IsDeleted, p => p.User);
            if (photos.Count > -1)
            {
                return new DataResult<PhotoListDto>(ResultStatus.Success, new PhotoListDto
                {
                    Photos = photos,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<PhotoListDto>(ResultStatus.Error, "Fotoğraflar bulunamadı.", null);
        }

        public async Task<IDataResult<PhotoListDto>> GetAllByNonDeletedAndActive()
        {
            var photos =
                    await _unitOfWork.Photos.GetAllAsync(p => !p.IsDeleted && p.IsActive, p => p.User);
            if (photos.Count > -1)
            {
                return new DataResult<PhotoListDto>(ResultStatus.Success, new PhotoListDto
                {
                    Photos = photos,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<PhotoListDto>(ResultStatus.Error, "Fotoğraflar bulunamadı.", null);
        }


        public async Task<IResult> Add(PhotoAddDto photoAddDto)
        {
            // bizlere parametre oalrak gelen PhotoAddDto'nun bir Photo'ya map edilmesini istiyoruz
            var photo = _mapper.Map<Photo>(photoAddDto);
            photo.UserId = 1;
            await _unitOfWork.Photos.AddAsync(photo);
            await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, $"{photoAddDto.Title} başlıklı fotoğraf başarıyla eklenmiştir.");
        }

        public async Task<IResult> Delete(int photoId)
        {
            var result = await _unitOfWork.Photos.AnyAsync(p => p.Id == photoId);
            if (result)
            {
                var photo = await _unitOfWork.Photos.GetAsync(p => p.Id == photoId);
                photo.IsDeleted = true;
                await _unitOfWork.Photos.UpdateAsync(photo);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{photo.Title} başlıklı footoğraf başarıyla silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir fotoğraf bulunamadı.");
        }

        public async Task<IResult> HardDelete(int photoId)
        {
            var result = await _unitOfWork.Photos.AnyAsync(p => p.Id == photoId);
            if (result)
            {
                var photo = await _unitOfWork.Photos.GetAsync(p => p.Id == photoId);
                await _unitOfWork.Photos.DeleteAsync(photo);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{photo.Title} başlıklı fotoğraf başarıyla veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Böyle bir fotoğraf bulunamadı.");
        }

        public async Task<IResult> Update(PhotoUpdateDto photoUpdateDto)
        {
            var photo = _mapper.Map<Photo>(photoUpdateDto);
            await _unitOfWork.Photos.UpdateAsync(photo);
            await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, $"{photoUpdateDto.Title} başlıklı fotoğraf başarıyla güncellenmiştir.");
        }


    }

}
