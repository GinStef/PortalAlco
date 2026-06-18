using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CorteParcialFormaPago
{
    public short IdUniOper { get; set; }

    public int IdCaja { get; set; }

    public int IdCorte { get; set; }

    public byte IdFormaPago { get; set; }

    public decimal Venta { get; set; }

    public decimal VentaMn { get; set; }

    public decimal Devolucion { get; set; }

    public decimal DevolucionMn { get; set; }

    public decimal MontoEntrada { get; set; }

    public decimal MontoEntradaMn { get; set; }

    public decimal MontoSalida { get; set; }

    public decimal MontoSalidaMn { get; set; }

    public decimal Saldo { get; set; }

    public decimal SaldoMn { get; set; }

    public decimal VentaPedido { get; set; }

    public decimal VentaPedidoMn { get; set; }

    public decimal DevolucionPedido { get; set; }

    public decimal DevolucionPedidoMn { get; set; }

    public virtual CorteParcial CorteParcial { get; set; } = null!;

    public virtual FormaPago IdFormaPagoNavigation { get; set; } = null!;
}
