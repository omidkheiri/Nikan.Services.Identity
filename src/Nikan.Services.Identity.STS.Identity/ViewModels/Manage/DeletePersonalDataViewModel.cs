using System.ComponentModel.DataAnnotations;

namespace Nikan.Services.Identity.STS.Identity.ViewModels.Manage
{
  public class DeletePersonalDataViewModel
  {
    public bool RequirePassword { get; set; }

    [DataType(DataType.Password)]
    [Required]
    public string Password { get; set; }
  }
}








