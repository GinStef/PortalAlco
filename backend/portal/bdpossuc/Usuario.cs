using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public short IdUniOper { get; set; }

    public int IdUo { get; set; }

    public string ClaveUsuario { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string ApellidoPaterno { get; set; } = null!;

    public string? ApellidoMaterno { get; set; }

    public string AbrevUsuario { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime FechaVigPassword { get; set; }

    public byte IndAdministrador { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual ICollection<ArqueoTerminal> ArqueoTerminalIdUsuarioAuditaNavigations { get; set; } = new List<ArqueoTerminal>();

    public virtual ICollection<ArqueoTerminal> ArqueoTerminalIdUsuarioNavigations { get; set; } = new List<ArqueoTerminal>();

    public virtual ICollection<CorteParcial> CorteParcials { get; set; } = new List<CorteParcial>();

    public virtual ICollection<LogVentum> LogVenta { get; set; } = new List<LogVentum>();

    public virtual ICollection<PanelUsuario> PanelUsuarios { get; set; } = new List<PanelUsuario>();

    public virtual ICollection<UsuarioDescuento> UsuarioDescuentos { get; set; } = new List<UsuarioDescuento>();

    public virtual ICollection<UsuarioPermiso> UsuarioPermisos { get; set; } = new List<UsuarioPermiso>();

    public virtual ICollection<UsuarioUnidadOperativa> UsuarioUnidadOperativas { get; set; } = new List<UsuarioUnidadOperativa>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
