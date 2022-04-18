using Bouken_sha.Extension.Models;
using Bouken_sha.Extension.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bouken_sha.Extension._9Anime
{
    public class AnimeRepository : IAnimeRepository
    {
        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Anime>> FindAsync(AnimeFilter filter, AnimeOrder order, string search, int page, int perPage)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Anime>> GetAsync(AnimeOrder order, int page, int perPage)
        {
            throw new NotImplementedException();
        }

        public Task<Anime> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Anime> UpsertAsync(Anime anime)
        {
            throw new NotImplementedException();
        }
    }
}
