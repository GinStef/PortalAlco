using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Proveedor
{
    public int IdProveedor { get; set; }

    public short IdUniOper { get; set; }

    public int IdUo { get; set; }

    public string NomProveedor { get; set; } = null!;

    public string NomComercial { get; set; } = null!;

    public string RfcProveedor { get; set; } = null!;

    public string CalleYNumero { get; set; } = null!;

    public string Colonia { get; set; } = null!;

    public string? CodigoPostal { get; set; }

    public string? EntreCalles { get; set; }

    public int IdCiudad { get; set; }

    public int IdTipoProv { get; set; }

    public string? NumCliente { get; set; }

    public string Telefono1 { get; set; } = null!;

    public string? Fax { get; set; }

    public string? PaginaWeb { get; set; }

    public DateTime FechaAlta { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual ICollection<ArticuloProveedor> ArticuloProveedors { get; set; } = new List<ArticuloProveedor>();

    public virtual ICollection<Devolucion> Devolucions { get; set; } = new List<Devolucion>();

    public virtual Ciudad IdCiudadNavigation { get; set; } = null!;

    public virtual TipoProveedor IdTipoProvNavigation { get; set; } = null!;

    public virtual ICollection<ProveedorCompra> ProveedorCompras { get; set; } = new List<ProveedorCompra>();

    public virtual ICollection<ProveedorContacto> ProveedorContactos { get; set; } = new List<ProveedorContacto>();

    public virtual ICollection<ProveedorCuentum> ProveedorCuenta { get; set; } = new List<ProveedorCuentum>();

    public virtual ICollection<ProveedorPago> ProveedorPagos { get; set; } = new List<ProveedorPago>();

    public virtual ICollection<ProveedorTipoproducto> ProveedorTipoproductos { get; set; } = new List<ProveedorTipoproducto>();

    public virtual ICollection<Recibo> Recibos { get; set; } = new List<Recibo>();
}
