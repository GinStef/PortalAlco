using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TarjetaCfDet
{
    public int IdTarjetaCf { get; set; }

    public int IdTarjeta { get; set; }

    public string IdCodigoBarras { get; set; } = null!;

    public byte IdTipoTarjeta { get; set; }

    public int IdLote { get; set; }

    public int Id { get; set; }

    public byte IndAsignado { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime? FechaMovimiento { get; set; }

    public string? UsuarioModifica { get; set; }

    public bool IndVigente { get; set; }

    public virtual ClienteTarjetaCf? ClienteTarjetaCf { get; set; }

    public virtual ICollection<EsMovimientoSocio> EsMovimientoSocios { get; set; } = new List<EsMovimientoSocio>();

    public virtual ICollection<MovimientoSocio> MovimientoSocios { get; set; } = new List<MovimientoSocio>();

    public virtual SaldoSocio? SaldoSocio { get; set; }

    public virtual ICollection<SaldoSocioHist> SaldoSocioHists { get; set; } = new List<SaldoSocioHist>();
}
