using System;
using System.Collections.Generic;
using System.Text;

namespace Bouken_sha.Repository.Sqlite
{
    public class SqliteHistoryRepository : IHistoryRepository
    {
        private readonly SqliteDatabaseContext _db;

        public SqliteHistoryRepository(SqliteDatabaseContext db)
        {
            _db = db;
        }
    }
}
