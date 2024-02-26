using HexaopsNewWebAPP.Entites;

namespace HexaopsNewWebAPP.Entities.About
{
	public class AboutService1: BaseEntity

	{
		public string? TextLGTitle1{ get; set; }
		public string? TextLGTitle2 { get; set; }

		public List<AboutService1Assoc> Service1Assocs { get; set; } = new List<AboutService1Assoc>();
		


	}
}
