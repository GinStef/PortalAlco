using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class SatPai
{
    public short IdPaisSat { get; set; }

    public string CvePais { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool IndVigente { get; set; }

    public string? UsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaMovimiento { get; set; }
}
