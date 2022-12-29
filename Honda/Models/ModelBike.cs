using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Honda.Models
{
	[Table("ModelBike")]
	public class ModelBike
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ModelId { get; set; }

		[Required(ErrorMessage = "Please Enter Model Of Bike!!!")]
		[StringLength(255)] 
		[Display(Name = "Model Of Bike")]
		public string Name { get; set; }

		
		[ForeignKey("Make")]
		[Display(Name = "Make")]
		public int? MakeId { get; set; }

		public virtual Make Make { get; set; }

	}
}
