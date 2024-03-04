using HexaopsNewWebAPP.Entites;

namespace HexaopsNewWebAPP.Entities.About
{
    public class AboutHowWeWork: BaseEntity
    {
        public string? HeaderTitle { get; set; }
        public string? Title { get; set; }
        public List<AboutHowWeWorkAssoc> AboutHowWeWorkAssocs { get; set; }
    }
}
