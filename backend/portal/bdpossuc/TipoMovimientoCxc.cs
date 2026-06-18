using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoMovimientoCxc
{
    public int IdTipomovCxc { get; set; }

    public string? NomTipomovCxc { get; set; }

    public string? AbrevTipomovCxc { get; set; }

    public int? IndEntradasalida { get; set; }

    public byte? IndAuto { get; set; }

    public int? IdDocumento { get; set; }

    public int? IdTipomovCxcAnula { get; set; }

    public string? UsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime? FechaModifica { get; set; }

    public bool? IndVigente { get; set; }
}
