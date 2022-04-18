using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Bouken_sha.Extension.Repository;
using Bouken_sha.Models;

namespace Bouken_sha.Repository
{
    public interface IExtensionRepository
    {
        Task<IEnumerable<Extensions>> GetAsync();
        Task<IEnumerable<Extensions>> FindAsync(string search);
        Task<Extensions> GetAsync(string id);
        Task<Extensions> UpsertAsync(string zipPath);
        Task DeleteAsync(string id);
        Task<IAnimeRepository> GetRepository(string id);
    }
}
