using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Subdivision
{
    public int IdSubdivision { get; set; }

    public int IdDivision { get; set; }

    public short IdUniOper { get; set; }

    public int IdUo { get; set; }

    public string NomSubdivision { get; set; } = null!;

    public string AbrevSubdivision { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public int? IdProdServ { get; set; }

    public virtual ICollection<Familium> Familia { get; set; } = new List<Familium>();

    public virtual Division IdDivisionNavigation { get; set; } = null!;
}
