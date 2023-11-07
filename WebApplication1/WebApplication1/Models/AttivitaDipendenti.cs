using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class AttivitaDipendenti
{
    public DateTime? DataAttivita { get; set; }

    public string? Attivita { get; set; }

    public decimal? Ore { get; set; }

    public string? Matricola { get; set; }

    public int Id { get; set; }

    public virtual AnagraficaGenerale? MatricolaNavigation { get; set; }
}
