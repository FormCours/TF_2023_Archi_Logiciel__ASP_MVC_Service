using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThai.Models.Data.Interfaces.CRUD
{
    public interface IReaderRepository<TId, TEntity>
    {
        IEnumerable<TEntity> GetAll();

        TEntity? GetbyId(TId id);
    }
}
