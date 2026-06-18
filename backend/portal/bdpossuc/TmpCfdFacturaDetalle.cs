using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TmpCfdFacturaDetalle
{
    public int Idproceso { get; set; }

    public int Id { get; set; }

    public int IdOrden { get; set; }

    public int Sku { get; set; }

    public string SkuInterno { get; set; } = null!;

    public string NomArticulo { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public decimal Precio { get; set; }

    public decimal PrecioSiva { get; set; }

    public decimal Importe { get; set; }

    public string NomImpuesto { get; set; } = null!;

    public string TasaImpuesto { get; set; } = null!;

    public decimal ImporteImpuesto { get; set; }

    public string? Medida { get; set; }

    public int? IdImpuesto { get; set; }

    public decimal? Costo { get; set; }

    public decimal? CostoSiva { get; set; }

    public decimal? CostoImporte { get; set; }

    public decimal? CostoImpuesto { get; set; }

    public decimal? PorcjDesc { get; set; }

    public string? Concepto { get; set; }

    public int? Idcliente { get; set; }

    public string? NomFormaPago { get; set; }

    public string? NumeroCuenta { get; set; }

    public string? CveProdServ { get; set; }

    public string? CveUnidadMedida { get; set; }

    public string? ClaveImpuestoSat { get; set; }

    public string? TipoFactorSat { get; set; }
}
