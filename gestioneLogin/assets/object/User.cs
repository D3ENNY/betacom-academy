using System.ComponentModel.DataAnnotations;

namespace gestioneLogin.assets.obj;

public class User
{
    [Required]
    public string Username{get;set;} =  string.Empty;
    [StringLength(64)]
    [Required]
    public string pwHash{get;set;} = string.Empty;
}