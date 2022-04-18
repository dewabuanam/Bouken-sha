using Bouken_sha.Extension.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bouken_sha.Extension.Repository
{
    public interface IAnimeRepository
    {
        Task<IEnumerable<Anime>> GetAsync(AnimeOrder order, int page, int perPage);
        Task<IEnumerable<Anime>> FindAsync(AnimeFilter filter, AnimeOrder order, string search, int page, int perPage);
        Task<Anime> GetAsync(string id);
        Task<Anime> UpsertAsync(Anime anime);
        Task DeleteAsync(string id);
    }
}
