using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Articulo
{
    public int Sku { get; set; }

    public short IdUniOper { get; set; }

    public int IdUo { get; set; }

    public string SkuInterno { get; set; } = null!;

    public string NomArticulo { get; set; } = null!;

    public short IdUnidadMedida { get; set; }

    public bool IndControlSerie { get; set; }

    public int IdFamilia { get; set; }

    public short IdImpuesto { get; set; }

    public decimal Costo { get; set; }

    public decimal CostoConIva { get; set; }

    public decimal CostoPromedio { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public byte IdEstatusArticulo { get; set; }

    public int IdModelo { get; set; }

    public int IdMarca { get; set; }

    public short IdMoneda { get; set; }

    public bool IndInventario { get; set; }

    public byte IdTipoArticulo { get; set; }

    public decimal CostoTc { get; set; }

    public string? Edicion { get; set; }

    public string? IdExterno { get; set; }

    public bool IndGranel { get; set; }

    public bool IndVolumen { get; set; }

    public short? IdAlmacen { get; set; }

    public string? DescripcionPos { get; set; }

    public decimal? CostoUltimo { get; set; }

    public bool IndConsolidado { get; set; }

    public byte IndCostopaquete { get; set; }

    public decimal CostoEstandar { get; set; }

    public int? IdProdServ { get; set; }

    public virtual ICollection<ArticuloConsolidar> ArticuloConsolidarSkuConsolidarNavigations { get; set; } = new List<ArticuloConsolidar>();

    public virtual ICollection<ArticuloConsolidar> ArticuloConsolidarSkuNavigations { get; set; } = new List<ArticuloConsolidar>();

    public virtual ICollection<ArticuloEmpaque> ArticuloEmpaques { get; set; } = new List<ArticuloEmpaque>();

    public virtual ICollection<ArticuloPrecioVoluman> ArticuloPrecioVolumen { get; set; } = new List<ArticuloPrecioVoluman>();

    public virtual ICollection<ArticuloPrecio> ArticuloPrecios { get; set; } = new List<ArticuloPrecio>();

    public virtual ICollection<ArticuloProveedor> ArticuloProveedors { get; set; } = new List<ArticuloProveedor>();

    public virtual ICollection<ArticuloTransformado> ArticuloTransformadoSkuNavigations { get; set; } = new List<ArticuloTransformado>();

    public virtual ICollection<ArticuloTransformado> ArticuloTransformadoSkuTransformadoNavigations { get; set; } = new List<ArticuloTransformado>();

    public virtual ICollection<ClientePrecio> ClientePrecios { get; set; } = new List<ClientePrecio>();

    public virtual ICollection<CodigoArticulo> CodigoArticulos { get; set; } = new List<CodigoArticulo>();

    public virtual EstatusArticulo IdEstatusArticuloNavigation { get; set; } = null!;

    public virtual Familium IdFamiliaNavigation { get; set; } = null!;

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;

    public virtual Marca IdMarcaNavigation { get; set; } = null!;

    public virtual Modelo IdModeloNavigation { get; set; } = null!;

    public virtual Monedum IdMonedaNavigation { get; set; } = null!;

    public virtual TipoArticulo IdTipoArticuloNavigation { get; set; } = null!;

    public virtual UnidadMedidum IdUnidadMedidaNavigation { get; set; } = null!;

    public virtual ICollection<InventarioFisicoDet> InventarioFisicoDets { get; set; } = new List<InventarioFisicoDet>();

    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();

    public virtual ICollection<PedidoDet> PedidoDets { get; set; } = new List<PedidoDet>();

    public virtual ICollection<PedidoEntregaDet> PedidoEntregaDets { get; set; } = new List<PedidoEntregaDet>();

    public virtual ICollection<RequisicionDet> RequisicionDets { get; set; } = new List<RequisicionDet>();
}
