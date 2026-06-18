using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public short IdUniOper { get; set; }

    public int IdUo { get; set; }

    public string Nombre { get; set; } = null!;

    public string? ApPaterno { get; set; }

    public string? ApMaterno { get; set; }

    public string? NombreComercial { get; set; }

    public string? Rfc { get; set; }

    public string? CalleYNumero { get; set; }

    public string? Colonia { get; set; }

    public string? CodigoPostal { get; set; }

    public string? EntreCalles { get; set; }

    public int? IdCiudad { get; set; }

    public string? Telefono1 { get; set; }

    public string? Fax { get; set; }

    public string? TelefonoOtro { get; set; }

    public string? Email { get; set; }

    public bool IndContado { get; set; }

    public byte PlazoPago { get; set; }

    public byte? TipoPeriodoPago { get; set; }

    public decimal LimiteCredito { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public int? Cuenta { get; set; }

    public int? Subcuenta { get; set; }

    public int? Ssubcuenta { get; set; }

    public int? Cuentar { get; set; }

    public int? Subcuentar { get; set; }

    public int? Ssubcuentar { get; set; }

    public string? NumeroExterior { get; set; }

    public string? NumeroInterior { get; set; }

    public string? IdClienteReferencia { get; set; }

    public decimal? SaldoCliente { get; set; }

    public byte IdTipocliente { get; set; }

    public byte IdTipoprecio { get; set; }

    public short IdLista { get; set; }

    public int IdGrupoCliente { get; set; }

    public byte IndFacturar { get; set; }

    public DateTime? FechaUltimoPago { get; set; }

    public short? IdRegimenFiscalSat { get; set; }

    public virtual ICollection<ClienteFormaPago> ClienteFormaPagos { get; set; } = new List<ClienteFormaPago>();

    public virtual ICollection<ClienteTarjetaCf> ClienteTarjetaCfs { get; set; } = new List<ClienteTarjetaCf>();

    public virtual ICollection<EsMovimientoSocio> EsMovimientoSocios { get; set; } = new List<EsMovimientoSocio>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Ciudad? IdCiudadNavigation { get; set; }

    public virtual GrupoCliente IdGrupoClienteNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;

    public virtual ICollection<MovimientoSocio> MovimientoSocios { get; set; } = new List<MovimientoSocio>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();

    public virtual ICollection<GrupoCliente> IdGrupoClientes { get; set; } = new List<GrupoCliente>();
}
