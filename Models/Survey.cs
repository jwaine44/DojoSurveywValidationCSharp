#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurveywValidation.Models;

public class Survey
{   
    [Required]
    [MinLength(2)]
    [Display(Name = "Your Name:")]
    public string Name {get;set;}
    [Required]
    [Display(Name = "Dojo Location:")]
    public string Location {get;set;}
    [Required]
    [Display(Name = "Favorite Language:")]
    public string FavLanguage {get;set;}
    [MinLength(21)]
    [Display(Name = "Comment (optional):")]
    public string? Comment {get;set;}
}