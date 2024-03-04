namespace HexaopsNewWebAPP.Entities.About
{
	public class AboutService1Assoc
	{
		public string? TextLGTitle1 { get; set; }
		public string? TextLGTitle2 { get; set; }
		public int AboutService1AssocId { get; set; }

		public AboutService1 AboutService1 { get; set; } = new AboutService1();
	}
}
