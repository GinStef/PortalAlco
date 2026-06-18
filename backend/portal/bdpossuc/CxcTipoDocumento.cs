using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CxcTipoDocumento
{
    public byte IdTipoDocumento { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Abrev { get; set; } = null!;

    public short IndTipoAfectacion { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioMovimiento { get; set; } = null!;

    public byte Idarea { get; set; }

    public short IndTipoAfectacionArea { get; set; }

    public bool IndVigente { get; set; }
}
