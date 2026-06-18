using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoMovimiento
{
    public short IdTipomov { get; set; }

    public string NomTipomov { get; set; } = null!;

    public short IndEntradasalida { get; set; }

    public bool IndManauto { get; set; }

    public short IdDocumento { get; set; }

    public short IdTipoMovGrupo { get; set; }

    public short? IdTipomovAnula { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual ICollection<Devolucion> Devolucions { get; set; } = new List<Devolucion>();

    public virtual ICollection<EsVaria> EsVaria { get; set; } = new List<EsVaria>();

    public virtual Documento IdDocumentoNavigation { get; set; } = null!;

    public virtual TipoMovimientoGrupo IdTipoMovGrupoNavigation { get; set; } = null!;

    public virtual ICollection<Merma> Mermas { get; set; } = new List<Merma>();

    public virtual ICollection<MovimientoInventario> MovimientoInventarios { get; set; } = new List<MovimientoInventario>();

    public virtual ICollection<Recibo> Recibos { get; set; } = new List<Recibo>();

    public virtual ICollection<Transformado> Transformados { get; set; } = new List<Transformado>();

    public virtual ICollection<VentaDevolucion> VentaDevolucions { get; set; } = new List<VentaDevolucion>();
}
