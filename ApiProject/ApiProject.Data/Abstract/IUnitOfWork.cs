using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Data.Abstract
{
    /* contextimizi dispose ediyor olacaz, garbage collectora yardımcı olacaz
    *  tüm repositoryleri bir yerden yönetmek amaçlı bu yapıyı kuruyoruz
    *  ef'ye bagimli degiliz */
    public interface IUnitOfWork : IAsyncDisposable
    {
        //resimlere erişmek amaçlı get
        IPhotoRepository Photos { get; } // unitofwork.Photos
        ICommentRepository Comments { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users { get; } // _unitOfWork.Comments.AddAsync();
        // _unitOfWork.Comments.AddAsync(comment);
        //_unitOfWork.Users.AddAsync(user);
        //_unitOfWork.SaveAsync();
        Task<int> SaveAsync();
    }
}
