using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class IfceInv
{
    public int Id { get; set; }

    public byte TipoMov { get; set; }

    public string Empresa { get; set; } = null!;

    public string Mov { get; set; } = null!;

    public string? MovId { get; set; }

    public DateTime? FechaEmision { get; set; }

    public DateTime? FechaRequerida { get; set; }

    public string? Concepto { get; set; }

    public string? Proyecto { get; set; }

    public int? Uen { get; set; }

    public string Moneda { get; set; } = null!;

    public double? TipoCambio { get; set; }

    public string? Usuario { get; set; }

    public string? Referencia { get; set; }

    public string? Observaciones { get; set; }

    public string? Estatus { get; set; }

    public string? Situacion { get; set; }

    public string? Prioridad { get; set; }

    public string? Almacen { get; set; }

    public string? AlmacenDestino { get; set; }

    public DateTime? Vencimiento { get; set; }

    public string? FormaEnvio { get; set; }

    public int Sucursal { get; set; }

    public int SucursalOrigen { get; set; }

    public int? SucursalDestino { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public DateTime? FechaProcesado { get; set; }

    public byte? EstatusProceso { get; set; }

    public string? TipoInterface { get; set; }
}
