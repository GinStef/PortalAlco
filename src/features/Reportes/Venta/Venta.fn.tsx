import {createServerFn} from "@tanstack/react-start";
import {ObtenerReporteDeVentaServer} from "#/features/Reportes/Venta/venta.server.tsx";
export interface ObtenerReporteVentaParams {
    fechaInicio: Date
    fechaFin: Date
    idUniOper: number
}

export const obtenerReporteVentaFn = createServerFn(
    {
        method: 'GET',
    }

).inputValidator((filtro:ObtenerReporteVentaParams)=>filtro)
    .handler(async({data})=>{
        return await ObtenerReporteDeVentaServer({fechaInicio: data.fechaInicio,fechaFin: data.fechaFin,idUniOper: data.idUniOper})
    })

