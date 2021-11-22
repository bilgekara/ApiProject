﻿using ApiProject.Core.Entities.Abstract;
using ApiProject.Core.Utilities.Results.ComplexTypes;
using ApiProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Entities.Dtos
{
    public class PhotoListDto : DtoGetBase
    {
        public IList<Photo> Photos { get; set; }
    }
}
