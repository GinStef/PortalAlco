using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class VentaDetalleCon
{
    public short IdUniOper { get; set; }

    public int IdVenta { get; set; }

    public int Orden { get; set; }

    public int Sku { get; set; }

    public short IdLista { get; set; }

    public short IdTipoprecio { get; set; }

    public short IndTipoPrecio { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Costo { get; set; }

    public decimal CostoConIva { get; set; }

    public decimal PrecioVenta { get; set; }

    public decimal PrecioVentaSinIva { get; set; }

    public decimal PrecioCliente { get; set; }

    public decimal PrecioClienteSinIva { get; set; }

    public decimal PrecioVolumen { get; set; }

    public decimal PrecioVolumenSinIva { get; set; }

    public decimal PrecioDescSup { get; set; }

    public decimal PrecioDescSupSinIva { get; set; }

    public decimal PrecioDescGral { get; set; }

    public decimal PrecioDescGralSinIva { get; set; }

    public decimal PrecioNeto { get; set; }

    public decimal PrecioNetoSinIva { get; set; }

    public decimal DescuentoPorc { get; set; }

    public decimal DescuentoSupPorc { get; set; }

    public decimal DescuentoGralPorc { get; set; }

    public byte DescuentoSupTipo { get; set; }

    public decimal Descuento { get; set; }

    public decimal DescuentoSinIva { get; set; }

    public short IdImpuesto { get; set; }

    public decimal Impuesto { get; set; }

    public short IdUnidadMedida { get; set; }

    public decimal CantidadEmpaque { get; set; }

    public decimal CantidadBase { get; set; }

    public decimal CostoBase { get; set; }

    public decimal CostoBaseConIva { get; set; }

    public decimal PrecioNetoBase { get; set; }

    public decimal PrecioNetoBaseSinIva { get; set; }

    public string IdCodigoBarras { get; set; } = null!;

    public byte Activo { get; set; }

    public virtual Ventum Ventum { get; set; } = null!;
}
