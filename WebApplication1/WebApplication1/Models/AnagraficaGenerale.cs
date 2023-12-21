using System.ComponentModel.DataAnnotations;
using WebApplication1.Models.ValidationManager;

namespace WebApplication1.Models;

public partial class AnagraficaGenerale
{
    [Key]
    [Required(ErrorMessage = "Matricola is required")]
    [RegularExpression(@"^[A-Z]{1}\d{3}$", ErrorMessage = "The format must be similar at I'X000\'")]
    [StringLength(4, ErrorMessage = "Matricola must be 4 lenght")]
    public string Matricola {get; set;}= null!;

    [MinLength(1, ErrorMessage = "Nominativo's min lenght must be equal to 1")]
    [MaxLength(50, ErrorMessage = "Nominativo's max lenght must be equals to 50")]
    public string? Nominativo { get; set; }

    [MinLength(1, ErrorMessage = "Ruolo's min lenght must be equal to 1")]
    [MaxLength(50, ErrorMessage = "Ruolo's max lenght must be equals to 50")]
    public string? Ruolo { get; set; }

    [Required(ErrorMessage = "Reparto is required")]
    [MinLength(1, ErrorMessage = "Reparto's min lenght must be equal to 1")]
    [MaxLength(50, ErrorMessage = "Reparto's max lenght must be equals to 50")]
    public string? Reparto { get; set; }

    [Required(ErrorMessage = "Eta is required")]
    [RegularExpression(@"^\d+$", ErrorMessage = "Eta must be a number")]
    [Range(16, 120, ErrorMessage = "Eta must be in range from 16yo to 120yo")]
    public int Eta { get; set; }
        
    [MinLength(3, ErrorMessage = "Indirizzo's min lenght must be equal to 3")]
    [MaxLength(50, ErrorMessage = "Indirizzo's max lenght must be equals to 50")]
    [FirstWord("via", "viale", "corso", "piazza", "piazzale", ErrorMessage = "the first word of Indizzo must be \'Via\' or \'viale\' or \'corso\' or \'piazza\' or \'piazzale\'")]
    public string? Indirizzo { get; set; }

    [MinLength(1, ErrorMessage = "Citta's min lenght must be equal to 1")]
    [MaxLength(50, ErrorMessage = "Citta's max lenght must be equals to 50")]
    public string? Citta { get; set; }

    [StringLength(2, MinimumLength = 1, ErrorMessage = "Provincia must be an acronym with max lenght 2 and minimum lenght 1")]
    public string? Provincia { get; set; }
    [RegularExpression(@"^\d{5}$", ErrorMessage = "Cap must be a number with 5 digits")]
    public string? Cap { get; set; }
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Telefono must be a number with italian format and without country code")]
    public string? Telefono { get; set; }   

    public string? Password { get; set; }

    public virtual ICollection<AttivitaDipendenti> AttivitaDipendentis { get; set; } = new List<AttivitaDipendenti>();

}
