using HexaopsNewWebAPP.Entites;

namespace HexaopsNewWebAPP.Entities.About
{
	public class AboutQuestions :BaseEntity
	{
		public string? ImagePath { get; set; }
		public string? Title { get; set; }
		public string? Descripton { get; set; }

		public List<AboutQuestionsAssoc> QuestionsAssoc { get; set; } 

	
	}
}
