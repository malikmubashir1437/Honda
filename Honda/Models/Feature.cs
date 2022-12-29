using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Honda.Models;
[Table("Feature")]
public class Feature
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FeatureId { get; set; }

    [Required(ErrorMessage = "Please Enter Features Of Bike!!!")]
    [StringLength(255)]
    [Display(Name = "Features Of Bike")]
    public string Name { get; set; }
}