using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class LogVentum
{
    public short IdUniOper { get; set; }

    public int IdLog { get; set; }

    public int IdTerminal { get; set; }

    public int IdUsuario { get; set; }

    public int IdCaja { get; set; }

    public int IdCorte { get; set; }

    public short IdLista { get; set; }

    public short IdTipoprecio { get; set; }

    public int IdCliente { get; set; }

    public string EstatusLog { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public decimal SubtotalBruto { get; set; }

    public decimal IvaBruto { get; set; }

    public decimal TotalBruto { get; set; }

    public decimal DescSubtotal { get; set; }

    public decimal DescIva { get; set; }

    public decimal DescTotal { get; set; }

    public decimal DescGral { get; set; }

    public decimal DescGralSubtotal { get; set; }

    public decimal DescGralIva { get; set; }

    public decimal DescGralTotal { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Iva { get; set; }

    public decimal Total { get; set; }

    public byte IndFacturar { get; set; }

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<LogVentaDesc> LogVentaDescs { get; set; } = new List<LogVentaDesc>();

    public virtual ICollection<LogVentaDetalle> LogVentaDetalles { get; set; } = new List<LogVentaDetalle>();

    public virtual ICollection<LogVentaForma> LogVentaFormas { get; set; } = new List<LogVentaForma>();
}
