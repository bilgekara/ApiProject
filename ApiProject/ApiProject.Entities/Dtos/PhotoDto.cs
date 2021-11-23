using ApiProject.Core.Entities.Abstract;
using ApiProject.Core.Utilities.Results.ComplexTypes;
using ApiProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Entities.Dtos
{
    public class PhotoDto : DtoGetBase
    {
        /* bir article bir result status tasimali cunku
         * result durumuna gore front end de icerigi degistirebilirim
         * amac esneklik kazandırmak
         * */
        public Photo Photo { get; set; }
    }
}
