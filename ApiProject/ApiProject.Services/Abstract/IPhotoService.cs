using ApiProject.Core.Utilities.Results.Abstract;
using ApiProject.Entities.Concrete;
using ApiProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Services.Abstract
{
    public interface IPhotoService
    {
        /* verileri tasimak amacli IDataResult olusturmustuk
         * Task<IDataResult<Category>> Get(int categoryId) -> sen kategori tipinde bir data result olacaksın
         * sen bana bir kategori id ver ben o kategoriyi bulup getiriyim
         * istersem bir kategori istersem de IList olarak kullanabliyorum.
         * IResult -> kategori basarili bir sekilde eklendiyse front end tarafına bir result dönüyoruz
         * -----------
         * DTO : front end tarafında sadece ihtiyacımız olacak sınıfları barındırır
         * CategoryAddDto -> Category'nin tamamını degil sadece front end kısmını kullanıcıdan istiyoru
         */
        Task<IDataResult<PhotoDto>> Get(int categoryId);
        Task<IDataResult<PhotoListDto>> GetAll();
        Task<IDataResult<PhotoListDto>> GetAllByNonDeleted();
        Task<IDataResult<PhotoListDto>> GetAllByNonDeletedAndActive();

        Task<IResult> Add(PhotoAddDto photoAddDto);
        Task<IResult> Update(PhotoUpdateDto photoUpdateDto);
        Task<IResult> Delete(int photoId);
        Task<IResult> HardDelete(int photoId);

    }
}
