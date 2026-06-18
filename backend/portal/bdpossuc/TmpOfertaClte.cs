using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class TmpOfertaClte
{
    public int Id { get; set; }

    public int IdSpid { get; set; }

    public int? IdFolioDet { get; set; }

    public int? IdFolio { get; set; }

    public short? IdUniOperFolio { get; set; }

    public int Sku { get; set; }

    public string IdCodigoBarras { get; set; } = null!;

    public int IdUniOper { get; set; }

    public string NombreUniOper { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public byte? IdTipoFecha { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public byte Dia1 { get; set; }

    public byte Dia2 { get; set; }

    public byte Dia3 { get; set; }

    public byte Dia4 { get; set; }

    public byte Dia5 { get; set; }

    public byte Dia6 { get; set; }

    public byte Dia7 { get; set; }

    public int? HoraMinima { get; set; }

    public int HoraInicio { get; set; }

    public int HoraFin { get; set; }

    public byte? IdTipoOferta { get; set; }

    public byte? IdEstatusOferta { get; set; }

    public int? IdImpuesto { get; set; }

    public decimal? ValorImpuesto { get; set; }

    public decimal? Costo { get; set; }

    public decimal? CostoConIva { get; set; }

    public decimal? Precio { get; set; }

    public decimal? PrecioSinIva { get; set; }

    public decimal? Margen { get; set; }

    public decimal? MargenO { get; set; }

    public decimal? MargenVig { get; set; }

    public decimal? PrecioOferta { get; set; }

    public decimal? PrecioOfertaSinIva { get; set; }

    public decimal? PrecioOfertaO { get; set; }

    public decimal? PrecioOfertaVig { get; set; }

    public decimal? Descuento1 { get; set; }

    public byte? IndIncluirOferta { get; set; }

    public byte? IndOfertaHora { get; set; }

    public byte? IndAgregado { get; set; }

    public byte? IndModificado { get; set; }

    public byte? IndAplicar { get; set; }

    public byte? TipoRegistro { get; set; }

    public byte? IndCancelar { get; set; }
}
