using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class MovimientoCxcDet
{
    public short IdUniOper { get; set; }

    public int FolioMov { get; set; }

    public short IdTipomov { get; set; }

    public byte IdFormaPago { get; set; }

    public decimal? Monto { get; set; }

    public decimal? MontoMn { get; set; }

    public virtual MovimientoCxc MovimientoCxc { get; set; } = null!;
}
