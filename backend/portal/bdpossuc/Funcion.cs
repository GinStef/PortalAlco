using System;
using System.Collections.Generic;

namespace portal.bdpossuc;

public partial class Funcion
{
    public short IdFuncion { get; set; }

    public string DescripcionFuncion { get; set; } = null!;

    public string NombreObjeto { get; set; } = null!;

    public bool IndCancelacion { get; set; }

    public bool IndSesionInicio { get; set; }

    public bool IndSesionCaptura { get; set; }

    public bool IndSesionPago { get; set; }

    public bool IndResetAut { get; set; }

    public string? AbrevFuncion { get; set; }

    public bool IndCorte { get; set; }
}
