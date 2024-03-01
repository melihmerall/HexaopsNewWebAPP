using HexaopsNewWebAPP.Entites;

namespace HexaopsNewWebAPP.Entities
{
	public class MainSolutions: BaseEntity
	{
		

		public List<MainSolutionsAsssoc> MainSolutionsAssoc {  get; set; }



		public string? SolutionsImagePath { get; set; }
		public string? SolutionsTitle { get; set; }
		public string? SolutionsDescription { get; set; }
		public string? SolutionsButtonUrl { get; set; }	

	}
}
