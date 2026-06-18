using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CambioCosto
{
    public short IdUniOper { get; set; }

    public int Sku { get; set; }

    public DateTime FechaIni { get; set; }

    public DateTime? FechaFin { get; set; }

    public byte? IdOrigen { get; set; }

    public decimal Existencia { get; set; }

    public decimal CostoExistencia { get; set; }

    public decimal Cantidad { get; set; }

    public decimal CostoCantidad { get; set; }

    public decimal? Costo { get; set; }

    public short? IdUniOperDoc { get; set; }

    public int? IdDocumento { get; set; }

    public decimal? CostoPromedio { get; set; }
}
