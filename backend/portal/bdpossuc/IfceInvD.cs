using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class IfceInvD
{
    public int Id { get; set; }

    public byte TipoMov { get; set; }

    public int Renglon { get; set; }

    public int RenglonSub { get; set; }

    public int? RenglonId { get; set; }

    public string? RenglonTipo { get; set; }

    public double? Cantidad { get; set; }

    public string? Almacen { get; set; }

    public string? Articulo { get; set; }

    public decimal? Costo { get; set; }

    public DateTime? FechaRequerida { get; set; }

    public string? Cliente { get; set; }

    public string? Unidad { get; set; }

    public double? Factor { get; set; }

    public double? CantidadInventario { get; set; }

    public int? Sucursal { get; set; }
}
