using HexaopsNewWebAPP.Entites;
namespace HexaopsNewWebAPP.Entities
{
    public class MainFeatureAssoc: BaseEntity
    {
        public string? Smalltitle { get; set; }
        public string? Smalldescription { get; set; }

        public MainFeatures MainFeatures { get; set; }

    }
}
