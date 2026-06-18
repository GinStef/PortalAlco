using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ProveedorContacto
{
    public int IdProveedor { get; set; }

    public int IdContactoProv { get; set; }

    public string Nombre { get; set; } = null!;

    public string ApellidoPaterno { get; set; } = null!;

    public string? ApellidoMaterno { get; set; }

    public string Departamento { get; set; } = null!;

    public string? Puesto { get; set; }

    public string Telefono1 { get; set; } = null!;

    public string? Telefono2 { get; set; }

    public string? NumeroFax { get; set; }

    public string? EMailContactoProv { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;
}
