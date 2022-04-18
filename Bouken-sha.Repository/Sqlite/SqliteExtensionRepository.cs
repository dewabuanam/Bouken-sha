using Bouken_sha.Extension.Repository;
using Bouken_sha.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bouken_sha.Repository.Sqlite
{
    public class SqliteExtensionRepository : IExtensionRepository
    {
        private readonly SqliteDatabaseContext _db;

        public SqliteExtensionRepository(SqliteDatabaseContext db)
        {
            _db = db;
        }
        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Extensions>> FindAsync(string search)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Extensions>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Extensions> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IAnimeRepository> GetRepository(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Extensions> UpsertAsync(string zipPath)
        {
            throw new NotImplementedException();
        }
    }
}
