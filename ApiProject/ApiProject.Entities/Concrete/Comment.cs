using ApiProject.Core.Entities.Abstract;
using ApiProject.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Entities.Concrete
{
    public class Comment : EntityBase, IEntity
    {
        public string Text { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
    }
}
