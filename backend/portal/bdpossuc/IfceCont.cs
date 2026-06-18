using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class IfceCont
{
    public int Id { get; set; }

    public byte TipoMov { get; set; }

    public string Empresa { get; set; } = null!;

    public string Mov { get; set; } = null!;

    public string? MovId { get; set; }

    public DateTime? FechaEmision { get; set; }

    public DateTime? FechaContable { get; set; }

    public string? Concepto { get; set; }

    public string? Proyecto { get; set; }

    public int? Uen { get; set; }

    public string Moneda { get; set; } = null!;

    public double? TipoCambio { get; set; }

    public string? Usuario { get; set; }

    public string? Referencia { get; set; }

    public string? Observaciones { get; set; }

    public string? Estatus { get; set; }

    public int? Ejercicio { get; set; }

    public int? Periodo { get; set; }

    public int Sucursal { get; set; }

    public decimal? Importe { get; set; }

    public string? Moneda2 { get; set; }

    public DateTime? FechaProcesado { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public byte? EstatusProceso { get; set; }

    public string? TipoInterface { get; set; }

    public string? OrigenTabla { get; set; }

    public byte? OrigenTipoMov { get; set; }

    public int? OrigenId { get; set; }
}
