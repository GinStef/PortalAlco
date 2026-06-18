using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ArticuloProveedorUo
{
    public int Sku { get; set; }

    public int IdProveedor { get; set; }

    public short IdUniOper { get; set; }

    public decimal Costo { get; set; }

    public bool IndProvPrincipal { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public virtual ArticuloProveedor ArticuloProveedor { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;
}
