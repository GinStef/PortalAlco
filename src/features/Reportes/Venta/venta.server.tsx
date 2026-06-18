import type {ReporteSucursal} from "#/features/Reportes/Venta/venta.schema.tsx";

interface Props {
    fechaInicio: Date
    fechaFin: Date
    idUniOper: number
}

export async function ObtenerReporteDeVentaServer(
    {
        fechaInicio, fechaFin, idUniOper

    }: Props
) {

    const UrlPortalAlco = 'https://localhost:7266/VentaTotal/PorTienda?' +
        'fechaIni=' + fechaInicio.toISOString() +
        '&fechaFin=' + fechaFin.toISOString() +
        '&idUnidadOperativa=' + idUniOper;

    const response = await fetch(UrlPortalAlco,
    {
        headers: {
        "Content-Type" : "application/json"
        }
    });

    if (response.ok) {
        const payload: ReporteSucursal[] = await response.json();
        return payload;
    } else {
        const errorMessage = await response.text()
        const resEstatus = response.statusText;
        throw new Error(errorMessage + resEstatus)
    }
}

