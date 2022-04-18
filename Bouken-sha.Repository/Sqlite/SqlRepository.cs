using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bouken_sha.Repository.Sqlite
{
    internal class SqlRepository : IRepository
    {
        private readonly DbContextOptions<SqliteDatabaseContext> _dbOptions;

        public SqlRepository(DbContextOptionsBuilder<SqliteDatabaseContext>
            dbOptionsBuilder)
        {
            _dbOptions = dbOptionsBuilder.Options;
            using (var db = new SqliteDatabaseContext(_dbOptions))
            {
                db.Database.EnsureCreated();
            }
        }

        public IHistoryRepository Histories => new SqliteHistoryRepository(
            new SqliteDatabaseContext(_dbOptions));

        public INewsRepository News => new SqliteNewsRepository(
            new SqliteDatabaseContext(_dbOptions));

        public IExtensionRepository Extensions => new SqliteExtensionRepository(
            new SqliteDatabaseContext(_dbOptions));

        public IUpdateRepository Updates => new SqliteUpdateRepository(
            new SqliteDatabaseContext(_dbOptions));

        public ILibraryRepository Lirbraries => new SqliteLibraryRepository(
            new SqliteDatabaseContext(_dbOptions));
    }
}
