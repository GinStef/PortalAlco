using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class UsuarioPermiso
{
    public int IdPermiso { get; set; }

    public int IdUsuario { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual Permiso IdPermisoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
