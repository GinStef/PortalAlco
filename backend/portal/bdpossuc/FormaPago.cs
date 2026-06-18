using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class FormaPago
{
    public byte IdFormaPago { get; set; }

    public string NomFormaPago { get; set; } = null!;

    public bool IndTerminaTransaccion { get; set; }

    public short IdMoneda { get; set; }

    public bool IndAplicaAjuste { get; set; }

    public bool IndCliente { get; set; }

    public bool IndAutorizacion { get; set; }

    public int IndAfectaPunto { get; set; }

    public byte IdTipoForma { get; set; }

    public string? UsuarioAlta { get; set; }

    public DateTime FechaAlta { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public int IdFormaPagoSat { get; set; }

    public byte IndPos { get; set; }

    public byte IndCredito { get; set; }

    public virtual ICollection<ArqueoTerminalDetalle> ArqueoTerminalDetalles { get; set; } = new List<ArqueoTerminalDetalle>();

    public virtual ICollection<CorteParcialFormaPago> CorteParcialFormaPagos { get; set; } = new List<CorteParcialFormaPago>();

    public virtual ICollection<FormaPagoDenominacion> FormaPagoDenominacions { get; set; } = new List<FormaPagoDenominacion>();

    public virtual ICollection<LogVentaForma> LogVentaFormas { get; set; } = new List<LogVentaForma>();

    public virtual ICollection<PedidoEntregaPagoDet> PedidoEntregaPagoDets { get; set; } = new List<PedidoEntregaPagoDet>();

    public virtual ICollection<VentaFormaPago> VentaFormaPagos { get; set; } = new List<VentaFormaPago>();
}
