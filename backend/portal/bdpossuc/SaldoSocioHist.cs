using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class SaldoSocioHist
{
    public int IdTarjeta { get; set; }

    public DateTime FechaIni { get; set; }

    public DateTime? FechaFin { get; set; }

    public int Punto { get; set; }

    public decimal Monedero { get; set; }

    public virtual TarjetaCfDet IdTarjetaNavigation { get; set; } = null!;
}
