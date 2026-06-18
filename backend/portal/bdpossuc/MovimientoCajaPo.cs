using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class MovimientoCajaPo
{
    public short IdUniOper { get; set; }

    public int IdCaja { get; set; }

    public int IdMovimiento { get; set; }

    public int IdTipomovCaja { get; set; }

    public int IdTerminal { get; set; }

    public int IdCorte { get; set; }

    public int IdUsuario { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public decimal MontoMn { get; set; }

    public int? IndTipoCaja { get; set; }

    public decimal? SaldoAnterior { get; set; }

    public decimal? SaldoAnteriorEfec { get; set; }

    public decimal? SaldoAnteriorDoc { get; set; }

    public int? IdMovTraslado { get; set; }

    public int? IdMovimientoRef { get; set; }

    public int? IdTipoMovRef { get; set; }

    public virtual ICollection<MovimientoCajaPosDet> MovimientoCajaPosDets { get; set; } = new List<MovimientoCajaPosDet>();
}
