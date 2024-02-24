using HexaopsNewWebAPP.Entites;

namespace HexaopsNewWebAPP.Entities
{
	public class MainFeatures: BaseEntity

	{
		public string Bigtitle { get; set; }
		public string Bigdescription { get; set; }

		public List<MainFeatureAssoc> FeatureAssocs { get; set; }
		

	}
}
