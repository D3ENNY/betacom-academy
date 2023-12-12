using System.ComponentModel.DataAnnotations;

namespace WformApp1.Models
{
    internal class AnagraficaGenerale
    {
        [Key]
        public string Matricola { get; set; } = null!;

        public string Nominativo { get; set; } = null!;

        public string? Ruolo { get; set; }

        public int? Eta { get; set; }

        public virtual List<AttivitaDipendenti> AttivitaDipendenti { get; set; } = new List<AttivitaDipendenti>();
    }
}
