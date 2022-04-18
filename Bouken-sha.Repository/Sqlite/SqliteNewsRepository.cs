using System;
using System.Collections.Generic;
using System.Text;

namespace Bouken_sha.Repository.Sqlite
{
    public class SqliteNewsRepository : INewsRepository
    {
        private readonly SqliteDatabaseContext _db;

        public SqliteNewsRepository(SqliteDatabaseContext db)
        {
            _db = db;
        }
    }
}
