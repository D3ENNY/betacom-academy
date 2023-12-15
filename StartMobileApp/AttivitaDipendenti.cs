using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MauiAppAca4
{
    internal class AttivitaDipendenti
    {
        public DateTime DataAttivita { get; set; }

        public string Attivita { get; set; }

        public decimal Ore { get; set; }

        public string Matricola { get; set; }

        public int Id { get; set; }
    }
}
