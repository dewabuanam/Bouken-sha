using Bouken_sha.Extension.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bouken_sha.Extension.KissAnime
{
    public class EpisodeRepository : IEpisodeRepository
    {
        public Task DeleteAsync(string animeId, string epsId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Episode>> FindAsync(string animeId, EpisodeFilter filter, EpisodeOrder order, string epsId, int page, int perPage)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Episode>> GetAsync(string animeId, EpisodeOrder order, int page, int perPage)
        {
            throw new NotImplementedException();
        }

        public Task<Episode> GetAsync(string animeId, string id)
        {
            throw new NotImplementedException();
        }

        public Task<Episode> UpsertAsync(string animeId, Episode eps)
        {
            throw new NotImplementedException();
        }
    }
}
