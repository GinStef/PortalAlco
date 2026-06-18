using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Estado
{
    public int IdEstado { get; set; }

    public int IdPais { get; set; }

    public short IdUniOper { get; set; }

    public int IdUo { get; set; }

    public string NomEstado { get; set; } = null!;

    public string AbrevEstado { get; set; } = null!;

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual ICollection<Ciudad> Ciudads { get; set; } = new List<Ciudad>();

    public virtual Pai IdPaisNavigation { get; set; } = null!;
}
