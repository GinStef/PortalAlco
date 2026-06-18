using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class UnidadOperativaListaPrecio
{
    public short IdUniOper { get; set; }

    public short IdLista { get; set; }

    public bool IndDefault { get; set; }

    public bool IndMinrepcomision { get; set; }

    public virtual ListaPrecio IdListaNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;
}
