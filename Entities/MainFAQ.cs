using HexaopsNewWebAPP.Entites;

namespace HexaopsNewWebAPP.Entities
{
	public class MainFAQ: BaseEntity
	{
		public string? Title { get; set; }
		public string? Description { get; set; }

		public List<MainFAQAssoc> MainFAQAssoc  { get; set; }

	}
}
