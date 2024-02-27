using HexaopsNewWebAPP.Entites;

namespace HexaopsNewWebAPP.Entities.About
{
	public class AboutQuestionsAssoc:BaseEntity
	{
		public string? Title { get; set; }
		public string? Descripton { get; set; }

		public AboutQuestions AboutQuestions { get; set; } 

	}
}
