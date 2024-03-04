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

        public  DbSet<AboutQuestions> AboutQuestions { get; set; }
        public DbSet<AboutQuestionsAssoc> AboutQuestionsAssocs { get;set; }
        public DbSet<AboutService> AboutService { get; set; }
        public DbSet<AboutServiceAssoc> AboutServiceAssocs { get;  set; }
        public DbSet<AboutService1> AboutService1 { get; set; }
        public DbSet<AboutService1Assoc> AboutService1Assocs { get;  set; }
        public DbSet<AboutSlider> AboutSlider { get; set; }
        public DbSet<AboutSliderAssoc> AboutSliderAssocs { get;  set; }





    }
}
