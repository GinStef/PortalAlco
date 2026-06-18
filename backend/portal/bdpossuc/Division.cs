using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Division
{
    public int IdDivision { get; set; }

    public short IdUniOper { get; set; }

    public int IdUo { get; set; }

    public string NomDivision { get; set; } = null!;

    public string AbrevDivision { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public int? IdProdServ { get; set; }

    public virtual ICollection<Subdivision> Subdivisions { get; set; } = new List<Subdivision>();
}
