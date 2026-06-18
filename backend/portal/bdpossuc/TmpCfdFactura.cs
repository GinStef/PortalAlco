using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TmpCfdFactura
{
    public int IdProceso { get; set; }

    public int IdUniOper { get; set; }

    public int Id { get; set; }

    public decimal PorcjDesc { get; set; }

    public decimal Descuento { get; set; }

    public decimal SubTotal { get; set; }

    public decimal Impuesto { get; set; }

    public decimal Total { get; set; }

    public decimal SubTotalNeto { get; set; }

    public decimal ImpuestoNeto { get; set; }

    public decimal TotalNeto { get; set; }

    public byte IdTipoFactura { get; set; }

    public string? Serie { get; set; }

    public int? Folio { get; set; }

    public DateTime? Fecha { get; set; }

    public int? NumAprobacion { get; set; }

    public int? AnioAprobacion { get; set; }

    public string? Concepto { get; set; }

    public byte IndEstatusFactura { get; set; }

    public byte IndOrigen { get; set; }

    public string? Usuario { get; set; }

    public byte IndTipoFactura { get; set; }

    public int? IdUniOperFolio { get; set; }

    public int? IdCliente { get; set; }

    public decimal? CostoSubtotal { get; set; }

    public decimal? CostoImpuesto { get; set; }

    public decimal? CostoTotal { get; set; }

    public int? IdUniOperSerie { get; set; }

    public int IdUnioperVenta { get; set; }

    public string? NomMoneda { get; set; }

    public decimal? ValorTipoCambio { get; set; }

    public string? NomFormaPago { get; set; }

    public string? NumeroCuenta { get; set; }

    public string? NoVersion { get; set; }

    public byte? IndCfdi { get; set; }

    public string? MetodoPago { get; set; }

    public string? UsoCfdi { get; set; }
}
