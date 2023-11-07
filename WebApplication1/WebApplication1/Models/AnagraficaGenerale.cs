using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class AnagraficaGenerale
{
    public string Matricola { get; set; } = null!;

    public string? Nominativo { get; set; }

    public string? Ruolo { get; set; }

    public string? Reparto { get; set; }

    public byte? Eta { get; set; }

    public string? Indirizzo { get; set; }

    public string? Citta { get; set; }

    public string? Provincia { get; set; }

    public string? Cap { get; set; }

    public string? Telefono { get; set; }

    public virtual ICollection<AttivitaDipendenti> AttivitaDipendentis { get; set; } = new List<AttivitaDipendenti>();
}
