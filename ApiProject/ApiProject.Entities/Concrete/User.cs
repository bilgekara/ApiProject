using ApiProject.Core.Entities.Abstract;
using ApiProject.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Entities.Concrete
{
    public class User : EntityBase, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}
