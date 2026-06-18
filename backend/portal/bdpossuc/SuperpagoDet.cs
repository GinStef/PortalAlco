using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class SuperpagoDet
{
    public int IdUniOper { get; set; }

    public int IdSuperpago { get; set; }

    public int IdTipoDoc { get; set; }

    public int IdUniOperDoc { get; set; }

    public int IdMovDoc { get; set; }

    public byte? IdFormaPago { get; set; }

    public decimal? Monto { get; set; }

    public decimal? MontoMn { get; set; }

    public short? IdTipomovCxc { get; set; }

    public int? FolioMovCxc { get; set; }

    public decimal? MontoPagado { get; set; }

    public decimal? MontoPagadoOriginal { get; set; }

    public virtual Superpago Superpago { get; set; } = null!;
}
