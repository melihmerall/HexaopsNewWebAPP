using HexaopsNewWebAPP.Entites;

namespace HexaopsNewWebAPP.Entities.About
{
    public class AboutHowWeWorkAssoc: BaseEntity
    {
        public string? TitleAssoc { get; set; }
        public string? ImagePath {  get; set; }
        public List<AboutHowWeWorkAssocItems> AboutHowWeWorkAssocItems { get; set; }

        public AboutHowWeWork AboutHowWeWork { get; set; }
    }
}
