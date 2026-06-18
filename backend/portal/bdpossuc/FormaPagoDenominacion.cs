using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class FormaPagoDenominacion
{
    public byte IdFormaPago { get; set; }

    public decimal ValorDenominacion { get; set; }

    public int Orden { get; set; }

    public byte IdPresentacion { get; set; }

    public string UsuarioAlta { get; set; } = null!;

    public DateTime FechaAlta { get; set; }

    public string UsuarioModifica { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public bool IndVigente { get; set; }

    public virtual FormaPago IdFormaPagoNavigation { get; set; } = null!;
}
