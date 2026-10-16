import { CreadorExportador } from "./creador";
import { Exportador } from "./exportador";
import { ExportadorCSV, ExportadorExcel, ExportadorPDF } from "./exportadores";

export class CreadorPDF extends CreadorExportador {
  crearExportador(): Exportador {
    return new ExportadorPDF();
  }
}

export class CreadorCSV extends CreadorExportador {
  crearExportador(): Exportador {
    return new ExportadorCSV();
  }
}

export class CreadorExcel extends CreadorExportador {
  crearExportador(): Exportador {
    return new ExportadorExcel();
  }
}
