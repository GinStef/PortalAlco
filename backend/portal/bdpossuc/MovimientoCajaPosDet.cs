using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class MovimientoCajaPosDet
{
    public int IdMovimiento { get; set; }

    public short IdUniOper { get; set; }

    public int IdCaja { get; set; }

    public byte IdFormaPago { get; set; }

    public decimal Monto { get; set; }

    public decimal MontoMn { get; set; }

    public virtual MovimientoCajaPo MovimientoCajaPo { get; set; } = null!;
}
