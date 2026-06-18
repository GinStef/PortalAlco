import {createFileRoute, Link} from '@tanstack/react-router'

import {allSpeakers, allTalks} from 'content-collections'

import {Table} from "#/components/ui/table.tsx";
import type {DateRange} from "react-day-picker";
import {addDays} from "date-fns";
import {Card, CardContent} from "#/components/ui/card.tsx";
import {Calendar} from "#/components/ui/calendar.tsx";
import * as React from "react";
import {number, string} from "zod";

import {
    Combobox,
    ComboboxContent,
    ComboboxEmpty,
    ComboboxInput,
    ComboboxItem,
    ComboboxList,
} from "@/components/ui/combobox"


export const Route = createFileRoute('/')({
    component: HomePage,
})
function HomePage() {
    const [dateRange, setDateRange] = React.useState<DateRange | undefined>({
        from: new Date(new Date().getFullYear(), 0, 12),
        to: addDays(new Date(new Date().getFullYear(), 0, 12), 30),
    })

    interface UnidadOperativa{
        id: number;
        nombre: string;
    }
    const [unidades, setUnidades] = React.useState<UnidadOperativa[]>([]);

    React.useEffect(() => {
        fetch("https://localhost:7266/unidadesoperativas")
        .then(res => res.json())
            .then(data =>{
                setUnidades([{id:0,nombre:"Todos"}, ...data]);
            })
    },[]);

    const [unidadSeleccionada, setUnidadSeleccionada] = React.useState<number | null>(null);


    return (
        <div className="p-4">

            <Card className="mx-auto w-fit p-0">
                <CardContent className="p-0">
                    <Calendar
                        mode="range"
                        defaultMonth={dateRange?.from}
                        selected={dateRange}
                        onSelect={setDateRange}
                        numberOfMonths={2}
                        disabled={(date) =>
                            date > new Date() || date < new Date("1900-01-01")
                        }
                    />
                </CardContent>
            </Card>
            <Combobox items={unidades}>
                <ComboboxInput placeholder="Selecciona unidad operativa..." />
                <ComboboxContent>
                    <ComboboxEmpty>No se encontró la unidad.</ComboboxEmpty>
                    <ComboboxList>
                        {(item) => (
                            <ComboboxItem key={item.id} value={item.id.toString()}
                                          onSelect={() => setUnidadSeleccionada(item.id)}
                            >
                                {item.id} - {item.nombre}
                            </ComboboxItem>
                        )}
                    </ComboboxList>
                </ComboboxContent>
            </Combobox>
            <button
                className="mt-4 px-4 py-2 bg-blue-600 text-white rounded"
                onClick={() => {
                    if (!unidadSeleccionada || !dateRange?.from || !dateRange?.to) {
                        alert("Selecciona unidad y rango de fechas");
                        return;
                    }

                    fetch(`https://localhost:7266/VentaTotal/PorTienda?id=${unidadSeleccionada}&from=${dateRange.from.toISOString()}&to=${dateRange.to.toISOString()}`)
                        .then(res => res.json())
                        .then(data => {
                            console.log("Datos filtrados:", data);
                            // Aquí puedes pasar 'data' a tu <Table />
                        });
                }}
            >
                Buscar
            </button>


            <Table />
        </div>
    )
}
