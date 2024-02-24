using HexaopsNewWebAPP.Entities;
using Microsoft.EntityFrameworkCore;

namespace HexaopsNewWebAPP.Database.Context
{
	public class SqlServerContext: DbContext
	{
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
        {
        }
        public DbSet<MainService> MainServices { get; set; }
        public DbSet<MainServiceAssoc> MainServiceAssocs { get; set; }
        public DbSet<MainFeatures> MainFeatures { get; set; }
        public DbSet<MainFeatureAssoc> MainFeatureAssocs { get; set;}
        public DbSet<MainSolutions> MainSolutions { get; set; }

    }
}
