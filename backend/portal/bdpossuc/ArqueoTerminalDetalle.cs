using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ArqueoTerminalDetalle
{
    public short IdUniOper { get; set; }

    public int IdCaja { get; set; }

    public int IdArqueo { get; set; }

    public byte IdFormaPago { get; set; }

    public decimal ValorDenominacion { get; set; }

    public decimal Cantidad { get; set; }

    public decimal ImporteDenominacion { get; set; }

    public decimal ImporteFormapago { get; set; }

    public decimal ImporteFormapagoMn { get; set; }

    public decimal Saldo { get; set; }

    public decimal SaldoMn { get; set; }

    public decimal Diferencia { get; set; }

    public decimal DiferenciaMn { get; set; }

    public decimal TipoCambio { get; set; }

    public byte IndDenominacion { get; set; }

    public byte IndPrincipal { get; set; }

    public virtual ArqueoTerminal ArqueoTerminal { get; set; } = null!;

    public virtual FormaPago IdFormaPagoNavigation { get; set; } = null!;
}
