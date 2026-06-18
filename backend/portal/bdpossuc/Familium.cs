using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Familium
{
    public int IdFamilia { get; set; }

    public int IdSubdivision { get; set; }

    public short IdUniOper { get; set; }

    public int IdUo { get; set; }

    public string NomFamilia { get; set; } = null!;

    public string AbrevFamilia { get; set; } = null!;

    public decimal? Margen1 { get; set; }

    public decimal? Margen2 { get; set; }

    public decimal? Margen3 { get; set; }

    public decimal? Margen4 { get; set; }

    public decimal? Margen5 { get; set; }

    public decimal? Margen6 { get; set; }

    public decimal? Margen7 { get; set; }

    public decimal? Margen8 { get; set; }

    public decimal? Margen9 { get; set; }

    public decimal? Margen10 { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public int? IdProdServ { get; set; }

    public decimal DiasInventario { get; set; }

    public virtual ICollection<Articulo> Articulos { get; set; } = new List<Articulo>();

    public virtual Subdivision IdSubdivisionNavigation { get; set; } = null!;
}
