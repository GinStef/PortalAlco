using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoMovimientoSocio
{
    public short IdTipomovSocio { get; set; }

    public string NomTipomovSocio { get; set; } = null!;

    public short IndTipoAfectacion { get; set; }

    public byte IndTipoPrograma { get; set; }

    public byte IndSistema { get; set; }

    public short? IdTipomovSocioAnula { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaModifica { get; set; }

    public bool IndVigente { get; set; }

    public virtual ICollection<EsMovimientoSocio> EsMovimientoSocios { get; set; } = new List<EsMovimientoSocio>();

    public virtual ICollection<MovimientoSocio> MovimientoSocios { get; set; } = new List<MovimientoSocio>();
}
