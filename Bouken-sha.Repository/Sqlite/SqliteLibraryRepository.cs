using System;
using System.Collections.Generic;
using System.Text;

namespace Bouken_sha.Repository.Sqlite
{
    public class SqliteLibraryRepository : ILibraryRepository
    {
        private readonly SqliteDatabaseContext _db;

        public SqliteLibraryRepository(SqliteDatabaseContext db)
        {
            _db = db;
        }
    }
}
