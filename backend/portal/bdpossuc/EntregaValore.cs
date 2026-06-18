using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class EntregaValore
{
    public short IdUniOper { get; set; }

    public int IdEntrega { get; set; }

    public int IdCorteTienda { get; set; }

    public int IdMovimiento { get; set; }

    public decimal SaldoAnterior { get; set; }

    public decimal MontoMn { get; set; }

    public string? NombreChofer { get; set; }

    public int? NumCredencial { get; set; }

    public int? IdCompaniaValores { get; set; }

    public int? NumRemision { get; set; }

    public DateTime FechaAlta { get; set; }

    public string? UsuarioAlta { get; set; }

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;
}
