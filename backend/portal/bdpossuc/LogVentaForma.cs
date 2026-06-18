using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class LogVentaForma
{
    public short IdUniOper { get; set; }

    public int IdLog { get; set; }

    public int Orden { get; set; }

    public byte IdFormaPago { get; set; }

    public decimal Importe { get; set; }

    public decimal ImporteMn { get; set; }

    public int? IdCliente { get; set; }

    public int? IdTarjeta { get; set; }

    public int? FolioReferencia { get; set; }

    public virtual FormaPago IdFormaPagoNavigation { get; set; } = null!;

    public virtual LogVentum LogVentum { get; set; } = null!;
}
