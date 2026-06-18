using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoUnidadOperativa
{
    public short IdTipounioper { get; set; }

    public string NomTipounioper { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public byte IndConsolidar { get; set; }

    public byte IndVolumen { get; set; }

    public virtual ICollection<UnidadOperativa> UnidadOperativas { get; set; } = new List<UnidadOperativa>();
}
