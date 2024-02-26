using HexaopsNewWebAPP.Entites;

namespace HexaopsNewWebAPP.Entities.About
{
	public class AboutServiceAssoc:BaseEntity
	{
		public string? Title { get; set; }
		public string? Mobil1Title { get; set; }
		public string? Mobil1ImagePath { get; set; }
		public string? Mobil1SmallTitle { get; set; }

		public string? Mobil1Descripton { get; set; }


		public string? Requirement1Title { get; set; }
		public string? Requirement1ImagePath { get; set; }
		public string? Requirement1SmallTitle { get; set; }


		public string? Requirement1Descripton { get; set; }

		public AboutService AboutService { get; set; } = new AboutService();
	}
}
