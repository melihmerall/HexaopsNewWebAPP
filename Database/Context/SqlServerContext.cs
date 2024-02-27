using HexaopsNewWebAPP.Entites;
using HexaopsNewWebAPP.Entities;
using HexaopsNewWebAPP.Entities.About;
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

        public DbSet<MainSlider> MainSliders { get; set; }

        public DbSet<MainPartner> MainPartners { get; set; }
        public DbSet<MainPartnerAssoc> MainPartnerAssocs { get; set; }

        public DbSet<MainFAQ> MainFAQ { get; set; }
        public DbSet<MainFAQAssoc> MainFAQAssocs { get; set; }

        public DbSet<MainCarousel> MainCarousels { get; set; }

        public DbSet<SocialAccount> SocialAccounts { get; set; }
        public DbSet<MainFooter> MainFooters { get; set; }

        public DbSet<AboutHowWeWork> AboutHowWeWorks { get; set; }
        public DbSet<AboutHowWeWorkAssoc> AboutHowWeWorkAssocs { get; set; }
        public DbSet<AboutHowWeWorkAssocItems> AboutHowWeWorkAssocItems { get; set; }
        public DbSet<AboutQuestions> AboutQuestions { get; set; }
        public DbSet<AboutQuestionsAssoc> AboutQuestionsAssocs { get; set; }









    }
}
