using HexaopsNewWebAPP.Entites;

namespace HexaopsNewWebAPP.Entities
{
	public class MainPartner: BaseEntity
	{
        public string? Slogan { get; set; }
	

		public List<MainPartnerAssoc> MainPartnerAssocs { get; set; }
		

	


	}
}
