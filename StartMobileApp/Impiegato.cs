using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MauiAppAca4
{
    internal class Impiegato
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int iD { get; set; }

        [MaxLength(30)]
        public string name { get; set; }

        [StringLength(25, MinimumLength = 5, ErrorMessage = "Attività deve esssere compresa tra 5 e 25 caratteri.")]
        public string? activity { get; set; }
        public int activityYears { get; set; }
        [MaxLength(4)]
        public string employeeEnrollment { get; set; }

    }
}
