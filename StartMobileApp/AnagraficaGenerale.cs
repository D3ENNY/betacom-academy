using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppAca4
{
    class AnagraficaGenerale
    {
        public string Matricola { get; set; } = null!;

        [MaxLength(50)]
        public string Nominativo { get; set; }

        [MaxLength(30)]
        public string Ruolo { get; set; }

        [MaxLength(50)]
        public string Reparto { get; set; }

        public byte Eta { get; set; }

        public string Indirizzo { get; set; }

        public string Citta { get; set; }

        public string Provincia { get; set; }

        public string Cap { get; set; }

        public string Telefono { get; set; }
        
        public virtual ICollection<AttivitaDipendenti> AttivitaDipendentis { get; set; } = new List<AttivitaDipendenti>();
    }
}
