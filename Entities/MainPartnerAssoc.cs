using HexaopsNewWebAPP.Entites;

namespace HexaopsNewWebAPP.Entities
{
    public class MainPartnerAssoc: BaseEntity
    {
        public string? PartnerImagePath { get; set; }

        public MainPartner MainPartner { get; set; }

    }
}
