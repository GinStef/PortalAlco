using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class OfertaClienteDet
{
    public int IdFolioDet { get; set; }

    public int IdFolio { get; set; }

    public short IdUniOperFolio { get; set; }

    public int Sku { get; set; }

    public short IdUniOper { get; set; }

    public byte IdTipoOferta { get; set; }

    public string Estatus { get; set; } = null!;

    public decimal Costo { get; set; }

    public decimal CostoConIva { get; set; }

    public decimal Precio { get; set; }

    public decimal PrecioSinIva { get; set; }

    public decimal PrecioOferta { get; set; }

    public decimal PrecioOfertaSinIva { get; set; }

    public decimal Descuento { get; set; }

    public short IdImpuesto { get; set; }

    public byte IdTipoFecha { get; set; }

    public DateTime FechaIni { get; set; }

    public DateTime FechaFin { get; set; }

    public byte Dia1 { get; set; }

    public byte Dia2 { get; set; }

    public byte Dia3 { get; set; }

    public byte Dia4 { get; set; }

    public byte Dia5 { get; set; }

    public byte Dia6 { get; set; }

    public byte Dia7 { get; set; }

    public int HoraIni { get; set; }

    public int HoraFin { get; set; }

    public int? IdFolioDetRef { get; set; }

    public int? IdFolioRef { get; set; }

    public short? IdUniOperFolioRef { get; set; }

    public virtual Inventario Inventario { get; set; } = null!;

    public virtual OfertaCliente OfertaCliente { get; set; } = null!;
}
