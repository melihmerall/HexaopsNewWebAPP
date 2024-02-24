using HexaopsNewWebAPP.Entites;

namespace HexaopsNewWebAPP.Entities
{
    public class MainFAQAssoc: BaseEntity
    {

        public string? QuestionTitle { get; set; }
        public string? QuestionDescription { get; set; }



        public string? ContactTitle { get; set; }
        public MainFAQ MainFAQ { get; set; }
    }
}
