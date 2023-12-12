using System.ComponentModel.DataAnnotations;

namespace WformApp1.Models
{
    internal class AttivitaDipendenti
    {
        [Key]
        public int Id { get; set; }

        public DateTime DataAttivita { get; set; }

        public string Attivita { get; set; } = null!;
        public decimal Ore { get; set; }
    }
}
