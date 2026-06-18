using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ExistenciaHist
{
    public DateTime FechaIni { get; set; }

    public DateTime? FechaFin { get; set; }

    public short IdUniOper { get; set; }

    public int Sku { get; set; }

    public decimal Existencia { get; set; }

    public decimal Costo { get; set; }

    public decimal Precio { get; set; }

    public decimal CostoConIva { get; set; }

    public decimal PrecioSinIva { get; set; }

    public virtual Inventario Inventario { get; set; } = null!;
}
