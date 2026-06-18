using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class IfceContD
{
    public int Id { get; set; }

    public byte TipoMov { get; set; }

    public double Renglon { get; set; }

    public int RenglonSub { get; set; }

    public string? Cuenta { get; set; }

    public string? SubCuenta { get; set; }

    public string? SubCuenta2 { get; set; }

    public string? Concepto { get; set; }

    public decimal? Debe { get; set; }

    public decimal? Debe2 { get; set; }

    public decimal? Haber { get; set; }

    public decimal? Haber2 { get; set; }

    public string? Empresa { get; set; }

    public int? Ejercicio { get; set; }

    public int? Periodo { get; set; }

    public DateTime? FechaContable { get; set; }

    public int Sucursal { get; set; }
}
