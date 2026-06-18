using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class MovimientoSocio
{
    public short IdUniOper { get; set; }

    public int IdMovimiento { get; set; }

    public short IdTipomovSocio { get; set; }

    public int IdCliente { get; set; }

    public int IdTarjeta { get; set; }

    public decimal ValorMovimiento { get; set; }

    public decimal FactorAplicado { get; set; }

    public int IdOrigen { get; set; }

    public int? FolioDoc { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public decimal? SaldoAnterior { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual TarjetaCfDet IdTarjetaNavigation { get; set; } = null!;

    public virtual TipoMovimientoSocio IdTipomovSocioNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;
}
