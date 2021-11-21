using ApiProject.Data.Abstract;
using ApiProject.Data.Concrete.EntityFramework.Contexts;
using ApiProject.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        // cunku repositoryler constructor icerisinde bizden bir db context nesnesi istiyordu, projede kullandıgımız contexti burda onlara veriyor olacaz
        private readonly ApiProjectContext _context;
        //degerleri readonly yapmıyoruz cunku new'lencekler
        private EfPhotoRepository _photoRepository;
        private EfCommentRepository _commentRepository;
        private EfRoleRepository _roleRepository;
        private EfUserRepository _userRepository;

        public UnitOfWork(ApiProjectContext context)
        {
            _context = context;
        }

        /* repositorylerin somut hallerine ihtiyac var ->
         * bir interface newlenemez normal interface'i return etmemiz mümkün değil
         * bu interfacelerin somut hallerini entegre ediyoruz
         */
        public IPhotoRepository Photos => _photoRepository ?? new EfPhotoRepository(_context);

        public ICommentRepository Comments => _commentRepository ?? new EfCommentRepository(_context);

        public IRoleRepository Roles => _roleRepository ?? new EfRoleRepository(_context);

        public IUserRepository Users => _userRepository ?? new EfUserRepository(_context);

        // dispose metodunun async hali c# 8 ile geldi
        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
