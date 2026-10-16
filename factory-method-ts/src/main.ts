import { CreadorExportador } from "./creador";
import { CreadorCSV, CreadorExcel, CreadorPDF } from "./creadores";
import { CreadorJSON } from "./exportadorJSON";

const notas = ["Ana: 8", "Luis: 6", "Marta: 9"];

const creadores: CreadorExportador[] = [
  new CreadorPDF(),
  new CreadorCSV(),
  new CreadorExcel(),
  new CreadorJSON(),
];

for (const creador of creadores) {
  console.log(creador.generarInforme(notas));
}
