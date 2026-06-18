using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class EsMovimientoSocio
{
    public short IdUniOper { get; set; }

    public int IdMovimiento { get; set; }

    public byte IndTipoPrograma { get; set; }

    public short IdTipomovSocio { get; set; }

    public int FolioMov { get; set; }

    public int IdCliente { get; set; }

    public int IdTarjeta { get; set; }

    public decimal ValorMovimiento { get; set; }

    public string? Comentario { get; set; }

    public byte IdEstatus { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public short? IdTipomovSocioAnula { get; set; }

    public int? FolioMovAnula { get; set; }

    public string? UsuarioAnula { get; set; }

    public DateTime? FechaAnula { get; set; }

    public decimal SaldoPunto { get; set; }

    public decimal SaldoMonedero { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual TarjetaCfDet IdTarjetaNavigation { get; set; } = null!;

    public virtual TipoMovimientoSocio IdTipomovSocioNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;
}
