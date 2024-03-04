using HexaopsNewWebAPP.Entites;

namespace HexaopsNewWebAPP.Entities.About
{
    public class AboutHowWeWorkAssocItems: BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public AboutHowWeWorkAssoc AboutHowWeWorkAssoc { get; set; }
    }
}
