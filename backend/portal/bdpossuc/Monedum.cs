using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Monedum
{
    public short IdMoneda { get; set; }

    public string NomMoneda { get; set; } = null!;

    public string AbrevMoneda { get; set; } = null!;

    public bool IndBase { get; set; }

    public bool IndExtranjera { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public int? IdMonedaSat { get; set; }

    public virtual ICollection<ArticuloProveedor> ArticuloProveedors { get; set; } = new List<ArticuloProveedor>();

    public virtual ICollection<Articulo> Articulos { get; set; } = new List<Articulo>();

    public virtual ICollection<TipoCambio> TipoCambios { get; set; } = new List<TipoCambio>();
}
