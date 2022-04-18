using System;
using System.Collections.Generic;
using System.Text;

namespace Bouken_sha.Repository.Sqlite
{
    public class SqliteUpdateRepository : IUpdateRepository
    {
        private readonly SqliteDatabaseContext _db;

        public SqliteUpdateRepository(SqliteDatabaseContext db)
        {
            _db = db;
        }
    }
}
