using Bouken_sha.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bouken_sha.Repository.Sqlite
{
    public class SqliteDatabaseContext : DbContext
    {
        public SqliteDatabaseContext(DbContextOptions<SqliteDatabaseContext> options) : base(options)
        { }
        public DbSet<Extensions> Extensions { get; set; }
        public DbSet<AnimeLibrary> AnimeLibraries { get; set; }
        public DbSet<SeasonLibrary> SeasonLibraries { get; set; }
        public DbSet<EpisodeLibrary> EpisodeLibraries { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Update> Updates { get; set; }
    }
}
