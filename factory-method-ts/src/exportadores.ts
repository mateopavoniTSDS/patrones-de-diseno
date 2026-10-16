import { Exportador } from "./exportador";

export class ExportadorPDF implements Exportador {
  exportar(datos: string[]): string {
    return `[PDF] Informe: ${datos.join(" | ")}`;
  }
}

export class ExportadorCSV implements Exportador {
  exportar(datos: string[]): string {
    return `[CSV] ${datos.join(",")}`;
  }
}

export class ExportadorExcel implements Exportador {
  exportar(datos: string[]): string {
    return `[Excel] Hoja1: ${datos.join("; ")}`;
  }
}
