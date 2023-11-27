using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThai.Models.Data.Interfaces.CRUD
{
    // C -> Create
    // R -> Read
    // U -> Update
    // D -> Delete
    public interface ICrudRepository<TId, TEntity> : IReaderRepository<TId, TEntity>
    {
        TEntity Insert(TEntity data);

        bool Update(TId id, TEntity data);

        bool Delete(TId id);
    }
}
