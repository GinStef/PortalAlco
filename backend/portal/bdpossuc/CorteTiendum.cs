using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CorteTiendum
{
    public short IdUniOper { get; set; }

    public int IdCorteTienda { get; set; }

    public int IdTerminal { get; set; }

    public int IdEstatus { get; set; }

    public DateTime FechaIni { get; set; }

    public DateTime? FechaFin { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string? UsuarioCorte { get; set; }

    public DateTime? FechaCorte { get; set; }

    public decimal? VentaMn { get; set; }

    public decimal? DevolucionMn { get; set; }

    public decimal? MontoEntradaMn { get; set; }

    public decimal? MontoSalidaMn { get; set; }

    public decimal? SaldoMn { get; set; }

    public decimal? MontoentradaEfectivo { get; set; }

    public decimal? MontosalidaEfectivo { get; set; }

    public decimal? MontoentradaDocumento { get; set; }

    public decimal? MontosalidaDocumento { get; set; }

    public decimal? Montoefectivo { get; set; }

    public decimal? Montocajafuerte { get; set; }

    public decimal? Montodocumento { get; set; }

    public decimal? AjusteEfec { get; set; }

    public decimal? AjusteDoc { get; set; }

    public decimal? AjusteTot { get; set; }

    public decimal? SaldoInicialEfec { get; set; }

    public decimal? SaldoInicialDoc { get; set; }

    public decimal? SaldoInicialTot { get; set; }

    public decimal? MontoentradaEfecEi { get; set; }

    public decimal? MontosalidaEfecSi { get; set; }

    public virtual ICollection<CorteTiendaRelParcial> CorteTiendaRelParcials { get; set; } = new List<CorteTiendaRelParcial>();

    public virtual Terminal IdTerminalNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;
}
