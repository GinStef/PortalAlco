using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class UnidadMedidum
{
    public short IdUnidadMedida { get; set; }

    public string NomUnidadmedida { get; set; } = null!;

    public string AbrevUnimedida { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public bool IndVigente { get; set; }

    public string AbrevUnimedidaExt { get; set; } = null!;

    public int? IdUnidadMedidaSat { get; set; }

    public short Nodecimal { get; set; }

    public virtual ICollection<ArticuloEmpaque> ArticuloEmpaqueIdEmpaqueNavigations { get; set; } = new List<ArticuloEmpaque>();

    public virtual ICollection<ArticuloEmpaque> ArticuloEmpaqueIdUnidadMedidaNavigations { get; set; } = new List<ArticuloEmpaque>();

    public virtual ICollection<ArticuloTransformado> ArticuloTransformados { get; set; } = new List<ArticuloTransformado>();

    public virtual ICollection<Articulo> Articulos { get; set; } = new List<Articulo>();

    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();

    public virtual ICollection<PedidoDet> PedidoDets { get; set; } = new List<PedidoDet>();

    public virtual ICollection<PedidoEntregaDet> PedidoEntregaDets { get; set; } = new List<PedidoEntregaDet>();
}
