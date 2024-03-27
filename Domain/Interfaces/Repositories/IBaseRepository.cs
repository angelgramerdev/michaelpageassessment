using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> :
        IAdd<TEntity>, IEdit<TEntity>, IDelete, IGetUsers, IGetUser
    {
    }
}
