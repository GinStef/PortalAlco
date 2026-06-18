using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoCambio
{
    public short IdUniOperTc { get; set; }

    public int IdTipoCambio { get; set; }

    public short IdMoneda { get; set; }

    public short IdUniOper { get; set; }

    public int IdUo { get; set; }

    public decimal ValorCompra { get; set; }

    public decimal ValorVenta { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public virtual Monedum IdMonedaNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperTcNavigation { get; set; } = null!;
}
