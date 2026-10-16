import { CreadorExportador } from "./creador";
import { Exportador } from "./exportador";

export class ExportadorJSON implements Exportador {
  exportar(datos: string[]): string {
    return `[JSON] ${JSON.stringify(datos)}`;
  }
}

export class CreadorJSON extends CreadorExportador {
  crearExportador(): Exportador {
    return new ExportadorJSON();
  }
}
