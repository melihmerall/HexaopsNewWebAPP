using HexaopsNewWebAPP.Entities;

namespace HexaopsNewWebAPP.Entites
{
	public class MainPartner: BaseEntity
	{
        public string? Slogan { get; set; }
	

		public List<MainPartnerAssoc> MainPartnerAssocs { get; set; }

	


	}
}
