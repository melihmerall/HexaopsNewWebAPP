using HexaopsNewWebAPP.Entites;

namespace HexaopsNewWebAPP.Entities.About
{
	public class AboutQuestionsAssoc:BaseEntity
	{
		public string? ImagePath { get; set; }
		public string? Title { get; set; }
		public string? Questions { get; set; }
		public string? Descripton { get; set; }
		public int AboutQuestionsId { get; set; }

		public AboutQuestions AboutQuestions { get; set; } = new AboutQuestions();

	}
}
