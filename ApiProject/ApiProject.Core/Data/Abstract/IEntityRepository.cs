using ApiProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Core.Data.Abstract
{
    //class : referans tip
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        // predicate null olursa hepsini getir yoksa filtreyi uygula
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);

        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);

    }
}
