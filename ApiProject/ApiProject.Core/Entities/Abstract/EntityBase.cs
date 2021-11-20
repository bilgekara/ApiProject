using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Core.Entities.Concrete
{
    public abstract class EntityBase
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now; // override CreatedDate
        // bu entitie silindi mi, cunku sorguları yazarken silinmemis degerleri getir dicez
        public virtual bool IsDeleted { get; set; } = false; 
        public virtual bool IsActive { get; set; } = true; // bu entite aktif mi?
        public virtual string Note { get; set; }
    }
}
