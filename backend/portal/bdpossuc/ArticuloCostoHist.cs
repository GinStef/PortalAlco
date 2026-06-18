using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ArticuloCostoHist
{
    public int? Sku { get; set; }

    public short? IdUniOper { get; set; }

    public DateTime? FechaIni { get; set; }

    public DateTime? FechaFin { get; set; }

    public decimal? Costo { get; set; }

    public decimal? CostoEstandar { get; set; }

    public string? UsuarioModifica { get; set; }
}
