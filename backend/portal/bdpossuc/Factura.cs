using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Factura
{
    public short IdUniOper { get; set; }

    public int IdFactura { get; set; }

    public short IdUniOperFactura { get; set; }

    public byte IndOrigen { get; set; }

    public byte IdTipofactura { get; set; }

    public string SerieFactura { get; set; } = null!;

    public int IdFolioFactura { get; set; }

    public int IdCliente { get; set; }

    public byte IndEstatusFactura { get; set; }

    public DateTime FechaFactura { get; set; }

    public string UsuarioElabora { get; set; } = null!;

    public DateTime? FechaCancelacion { get; set; }

    public string? UsuarioCancela { get; set; }

    public string? Concepto { get; set; }

    public byte IndTipoFactura { get; set; }

    public decimal? PorcjDesc { get; set; }

    public decimal SubtotalO { get; set; }

    public decimal IvaO { get; set; }

    public decimal TotalO { get; set; }

    public decimal Descuento { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Iva { get; set; }

    public decimal Total { get; set; }

    public decimal Costosubtotal { get; set; }

    public decimal CostoImpuesto { get; set; }

    public decimal Costototal { get; set; }

    public string? Numaprobacion { get; set; }

    public int? Anioaprobacion { get; set; }

    public string? Sello { get; set; }

    public string? Certificado { get; set; }

    public byte IndInterfase { get; set; }

    public DateTime? FechaInterfase { get; set; }

    public int IdUnioperVenta { get; set; }

    public string? NomFormaPago { get; set; }

    public string? NumeroCuenta { get; set; }

    public string? NoVersion { get; set; }

    public string? Timbreversion { get; set; }

    public string? Timbreuuid { get; set; }

    public DateTime? Timbrefecha { get; set; }

    public string? Timbresellosat { get; set; }

    public string? Timbrenocertsat { get; set; }

    public string? MetodoPago { get; set; }

    public string? UsoCfdi { get; set; }

    public virtual CfdTipoFacturaOrigen CfdTipoFacturaOrigen { get; set; } = null!;

    public virtual ICollection<FacturaDetalle> FacturaDetalles { get; set; } = new List<FacturaDetalle>();

    public virtual ICollection<FacturaDocumento> FacturaDocumentos { get; set; } = new List<FacturaDocumento>();

    public virtual ICollection<FacturaImpuesto> FacturaImpuestos { get; set; } = new List<FacturaImpuesto>();

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperFacturaNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;
}
