using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThai.Models.Data.Repositories
{
    public class RepositoryBase
    {
        private readonly DbConnection _connection;

        protected DbConnection Connection 
        { 
            get { return _connection; } 
        }

        public RepositoryBase(DbConnection connection)
        {
            _connection = connection;
        }
    }
}
