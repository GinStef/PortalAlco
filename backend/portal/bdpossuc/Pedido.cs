using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Pedido
{
    public short IdUniOper { get; set; }

    public int IdMovimiento { get; set; }

    public int IdCliente { get; set; }

    public DateTime FechaEntrega { get; set; }

    public DateTime? FechaEntregaReal { get; set; }

    public short IdUniOperEntrega { get; set; }

    public byte IndCredito { get; set; }

    public string CveEstatusPedido { get; set; } = null!;

    public string CveEstatusPago { get; set; } = null!;

    public string CveEstatusOperativo { get; set; } = null!;

    public string CveEstatusFiscal { get; set; } = null!;

    public string CveEstatusRequisicion { get; set; } = null!;

    public decimal TotalPedido { get; set; }

    public decimal TotalEntregado { get; set; }

    public int? IdUniOperReq { get; set; }

    public int? IdMovimientoReq { get; set; }

    public string? Observaciones { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaModifica { get; set; }

    public string? UsuarioCancela { get; set; }

    public DateTime? FechaCancela { get; set; }

    public short IdLista { get; set; }

    public short IdTipoPrecio { get; set; }

    public string? UsuarioAutoriza { get; set; }

    public DateTime? FechaAutoriza { get; set; }

    public byte? IndRequisicionAlmacen { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual UnidadOperativa IdUniOperNavigation { get; set; } = null!;

    public virtual ICollection<PedidoDet> PedidoDets { get; set; } = new List<PedidoDet>();
}
