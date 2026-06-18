using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoMovimientoGrupo
{
    public short IdTipoMovGrupo { get; set; }

    public string NomTipoMovGrupo { get; set; } = null!;

    public bool IndManauto { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public string AbrevTipoMovGpo { get; set; } = null!;

    public virtual ICollection<TipoMovimiento> TipoMovimientos { get; set; } = new List<TipoMovimiento>();
}
