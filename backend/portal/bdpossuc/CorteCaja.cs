using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CorteCaja
{
    public short IdUniOper { get; set; }

    public int IdCaja { get; set; }

    public int IdCorteCaja { get; set; }

    public int IdTerminal { get; set; }

    public byte IdEstatus { get; set; }

    public DateTime FechaIni { get; set; }

    public DateTime? FechaFin { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string? UsuarioCorte { get; set; }

    public DateTime? FechaCorte { get; set; }

    public decimal VentaMn { get; set; }

    public decimal DevolucionMn { get; set; }

    public decimal MontoEntradaMn { get; set; }

    public decimal MontoSalidaMn { get; set; }

    public decimal SaldoMn { get; set; }

    public decimal? VentaEfec { get; set; }

    public decimal? DevEfec { get; set; }

    public decimal? VentaDoc { get; set; }

    public decimal? DevDoc { get; set; }

    public decimal? MontoEntEfectivo { get; set; }

    public decimal? MontoSalEfectivo { get; set; }

    public decimal? MontoEntradaDoc { get; set; }

    public decimal? MontoSalidaDoc { get; set; }

    public decimal? SaldoEfectivo { get; set; }

    public decimal? SaldoDoc { get; set; }

    public int? IdCorteTienda { get; set; }

    public decimal? AjusteEfec { get; set; }

    public decimal? AjusteDoc { get; set; }

    public decimal? AjusteTot { get; set; }

    public virtual ICollection<CorteParcial> CorteParcials { get; set; } = new List<CorteParcial>();

    public virtual Caja IdCajaNavigation { get; set; } = null!;

    public virtual Terminal IdTerminalNavigation { get; set; } = null!;
}
