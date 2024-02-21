using System.ComponentModel.DataAnnotations;

namespace HexaopsNewWebAPP.Entites
{
	public class BaseEntity
	{

		public int Id { get; set; }
		public DateTime CreatedDated { get; set; } = DateTime.Now;
	}
}
