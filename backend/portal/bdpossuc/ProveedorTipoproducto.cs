using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ProveedorTipoproducto
{
    public int IdProveedor { get; set; }

    public int IdTipoproducto { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;
}
