using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TipoComercializacion
{
    public byte IdTipoComercializacion { get; set; }

    public string NomTipo { get; set; } = null!;

    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();
}
