# Patrones de diseño creacionales

## Cómo correr

```bash
dotnet run --project PatronesCreacionales
cd factory-method-ts && npm install && npm start
```

## Singleton

1. Si el constructor fuera público, cualquiera podría hacer `new ConfiguracionSistema()` y crear varias instancias.
2. Se pierde la garantía de instancia única y de estado compartido: cada módulo podría tener su propia configuración y los cambios no se verían entre módulos.

## Builder

1. `PedidoBuilder` se encarga de construir el pedido paso a paso y de validarlo; `Pedido` solo representa los datos ya armados.
2. Los métodos devuelven `this` para poder encadenar las llamadas (interfaz fluida).
3. `Build()` permite validar al final y entregar un objeto completo y consistente; sin él se podría obtener un pedido a medio armar.
4. `Build()` lanza una `InvalidOperationException` porque falta al menos un producto.
5. Singleton.

## Prototype

1. Los clones ya creados no se ven afectados, porque son copias independientes (con su propia lista de habilidades); solo los clones futuros partirían del prototipo modificado.
2. Evita configurar cada personaje desde cero: se parte de un modelo ya armado y se ajusta solo lo que cambia.

## Factory Method

1. El cliente no crea `ExportadorPDF` directamente para no depender de la clase concreta; solo conoce la interfaz y el creador abstracto.
2. `crearExportador()`, método abstracto de `CreadorExportador` que implementa cada creador concreto.
3. El producto es el objeto que se usa (`Exportador` y sus implementaciones); el creador es la clase que decide qué producto instanciar y tiene la lógica común.
4. `ExportadorJSON` (producto) y `CreadorJSON` (creador concreto).
5. Un `switch` centralizado hay que modificarlo con cada formato nuevo; con Factory Method se agregan clases sin tocar las existentes.
