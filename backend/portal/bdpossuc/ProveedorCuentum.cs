using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ProveedorCuentum
{
    public int IdProveedor { get; set; }

    public string Cuenta { get; set; } = null!;

    public short IdBanco { get; set; }

    public string Clabe { get; set; } = null!;

    public string Nomsucursal { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public virtual Banco IdBancoNavigation { get; set; } = null!;

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;
}
