import { Exportador } from "./exportador";

export abstract class CreadorExportador {
  // Factory Method: cada creador concreto decide el exportador
  abstract crearExportador(): Exportador;

  generarInforme(datos: string[]): string {
    const exportador = this.crearExportador();
    return exportador.exportar(datos);
  }
}
