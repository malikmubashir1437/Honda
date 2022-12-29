using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Honda.Models
{
	[Table("Make")]
	public class Make
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int MakeId { get; set; }

		[Required(ErrorMessage = "Please Enter Make Of Bike!!!")]
		[StringLength(255)]
		[Display(Name = "Make Of Bike")]
		public string Name { get; set; }

		public virtual IEnumerable<ModelBike> ModelBike { get; set; }
	}
}
