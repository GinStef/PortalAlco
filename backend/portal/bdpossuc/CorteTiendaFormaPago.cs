using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class CorteTiendaFormaPago
{
    public byte IdFormaPago { get; set; }

    public int IdCorteTienda { get; set; }

    public int IdUniOper { get; set; }

    public decimal? MontoFormaPago { get; set; }

    public decimal? MontoCaptura { get; set; }

    public decimal? MontoAjuste { get; set; }

    public string? UsuarioAlta { get; set; }

    public DateTime FechaAlta { get; set; }

    public string? UsuarioModifica { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public string? Comentario { get; set; }
}
