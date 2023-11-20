using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using WebApplication1.Models.ValidationManager;

namespace WebApplication1.Models;

public partial class AttivitaDipendenti
{
    [Required]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [PreviousDate(true, ErrorMessage = "DataAttivita must be previous than today")]
    public DateTime? DataAttivita { get; set; }

    [MinLength(3, ErrorMessage = "Attivita's min lenght must be equal to 3")]
    [MaxLength(50, ErrorMessage = "Attivita's max lenght must be equals to 50")]
    public string? Attivita { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Ore must be a positive number")]
    [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "ore must have maximium two decimal number")]
    public decimal? Ore { get; set; }

    [Required(ErrorMessage = "Matricola is required")]
    [RegularExpression(@"^[A-Z]{1}\d{3}$", ErrorMessage = "The format must be similar at I'X000\'")]
    [StringLength(4, ErrorMessage = "Matricola must be 4 lenght")]
    public string? Matricola { get; set; }
    [Key]
    //[RegularExpression(@"^\d+^", ErrorMessage = "id must be a number")]
    public int Id { get; set; }

    public virtual AnagraficaGenerale? MatricolaNavigation { get; set; } = null;
}
