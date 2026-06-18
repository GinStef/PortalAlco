using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Permiso
{
    public int IdPermiso { get; set; }

    public string NomPermiso { get; set; } = null!;

    public bool IndValidar { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual ICollection<UsuarioPermiso> UsuarioPermisos { get; set; } = new List<UsuarioPermiso>();
}
