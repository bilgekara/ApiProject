using ApiProject.Core.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Core.Entities.Abstract
{
    public abstract class DtoGetBase
    {
        // get işlemleri icin kullanılcak, add durumunda zaten bir result donuyor
        public virtual ResultStatus ResultStatus { get; set; }
    }
}
