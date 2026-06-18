using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Panel
{
    public short IdPanel { get; set; }

    public byte IdNodo { get; set; }

    public byte OrdenPanel { get; set; }

    public string NombrePanel { get; set; } = null!;

    public string TituloPanel { get; set; } = null!;

    public string NombreIcono16 { get; set; } = null!;

    public string NombreIcono32 { get; set; } = null!;

    public string NombreUoPanel { get; set; } = null!;

    public string? NombreUoPanelControl { get; set; }

    public bool IndPanelControl { get; set; }

    public byte? TipoMenu { get; set; }

    public bool IndMuestraArbol { get; set; }

    public bool IndVerificaCuenta { get; set; }

    public bool IndVigente { get; set; }

    public bool? IndCatalogo { get; set; }

    public virtual Nodo IdNodoNavigation { get; set; } = null!;

    public virtual ICollection<PanelUsuario> PanelUsuarios { get; set; } = new List<PanelUsuario>();
}
