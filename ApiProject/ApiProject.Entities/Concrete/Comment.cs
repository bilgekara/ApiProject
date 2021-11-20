using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Entities.Concrete
{
    public class Comment
    {
        public string Text { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
    }
}
