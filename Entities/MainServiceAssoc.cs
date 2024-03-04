using HexaopsNewWebAPP.Entites;

namespace HexaopsNewWebAPP.Entities
{
    public class MainServiceAssoc: BaseEntity
    {
        public string? ServiceTitle { get; set; }
        public string? ServiceDescripton { get; set; }
        public string? ServiceImagePath { get; set; }
        public MainService MainService { get; set; }
    }
}
