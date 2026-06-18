using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Ventum
{
    public short IdUniOper { get; set; }

    public int IdVenta { get; set; }

    public int IdCaja { get; set; }

    public int IdFolioVenta { get; set; }

    public int IdCorte { get; set; }

    public short IdLista { get; set; }

    public short IdTipoprecio { get; set; }

    public int IdCliente { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public byte IdEstatus { get; set; }

    public short IdTipomov { get; set; }

    public int FolioMov { get; set; }

    public decimal DescGral { get; set; }

    public decimal Descuento { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Impuesto { get; set; }

    public decimal Total { get; set; }

    public decimal Pago { get; set; }

    public decimal Cambio { get; set; }

    public short? IdTipomovAnula { get; set; }

    public int? FolioMovAnula { get; set; }

    public int? IdUsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public string? Comentario { get; set; }

    public byte IndFacturado { get; set; }

    public int? IdTarjeta { get; set; }

    public byte IndFacturar { get; set; }

    public short? IdTipomovComp { get; set; }

    public int? FolioMovComp { get; set; }

    public short? IdTipomovCompAnula { get; set; }

    public int? FolioMovCompAnula { get; set; }

    public virtual CorteParcial CorteParcial { get; set; } = null!;

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<VentaDetalleCon> VentaDetalleCons { get; set; } = new List<VentaDetalleCon>();

    public virtual ICollection<VentaDetalle> VentaDetalles { get; set; } = new List<VentaDetalle>();

    public virtual ICollection<VentaDevolucion> VentaDevolucions { get; set; } = new List<VentaDevolucion>();

    public virtual ICollection<VentaFormaPago> VentaFormaPagos { get; set; } = new List<VentaFormaPago>();
}
