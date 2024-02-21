using HexaopsNewWebAPP.Entites;

namespace HexaopsNewWebAPP.Entities
{
	public class MainService : BaseEntity
	{
		public string? Title { get; set; }

		public List<MainServiceAssoc> MainServices { get; set; }


	}
}
