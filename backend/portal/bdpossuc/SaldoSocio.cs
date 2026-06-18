using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class SaldoSocio
{
    public int IdTarjeta { get; set; }

    public int Punto { get; set; }

    public decimal Monedero { get; set; }

    public virtual TarjetaCfDet IdTarjetaNavigation { get; set; } = null!;
}
