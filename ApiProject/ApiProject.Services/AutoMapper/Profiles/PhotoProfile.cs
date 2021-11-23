using ApiProject.Entities.Concrete;
using ApiProject.Entities.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Services.AutoMapper.Profiles
{
    public class PhotoProfile : Profile
    {
        // neyi neye donusturmek istiyorsak onu veriyoruz
        // kaynak,.. -> PhotoAddDto yu al Photo ya donsutur
        public PhotoProfile()
        {
            // ForMember -> PhotoAddDto da CreatedDate alanı yok ama Photo'da var 
            CreateMap<PhotoAddDto, Photo>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<PhotoUpdateDto, Photo>();
        }
     
    }
}
