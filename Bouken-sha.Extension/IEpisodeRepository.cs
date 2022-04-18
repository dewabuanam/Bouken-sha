using Bouken_sha.Extension.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bouken_sha.Extension
{
    public interface IEpisodeRepository
    {
        Task<IEnumerable<Episode>> GetAsync(string animeId, EpisodeOrder order, int page, int perPage);
        Task<IEnumerable<Episode>> FindAsync(string animeId, EpisodeFilter filter, EpisodeOrder order, string epsId, int page, int perPage);
        Task<Episode> GetAsync(string animeId, string id);
        Task<Episode> UpsertAsync(string animeId, Episode eps);
        Task DeleteAsync(string animeId, string epsId);
    }
}
