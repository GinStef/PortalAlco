using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class ListaPrecio
{
    public short IdLista { get; set; }

    public string NomLista { get; set; } = null!;

    public string AbrevLista { get; set; } = null!;

    public bool IndDefault { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public decimal? FactorPrecio { get; set; }

    public bool IndCliente { get; set; }

    public virtual ICollection<ArticuloPrecio> ArticuloPrecios { get; set; } = new List<ArticuloPrecio>();

    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();

    public virtual ICollection<UnidadOperativaListaPrecio> UnidadOperativaListaPrecios { get; set; } = new List<UnidadOperativaListaPrecio>();

    public virtual ICollection<UnidadOperativa> UnidadOperativas { get; set; } = new List<UnidadOperativa>();
}
