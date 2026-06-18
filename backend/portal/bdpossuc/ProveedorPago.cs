using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ProveedorPago
{
    public int IdProveedor { get; set; }

    public byte Consecutivo { get; set; }

    public short Dias { get; set; }

    public decimal Porcentaje { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;
}
