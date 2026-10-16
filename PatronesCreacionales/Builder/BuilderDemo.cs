namespace PatronesCreacionales.Builder;

public static class BuilderDemo
{
    public static void Ejecutar()
    {
        var pedido1 = new PedidoBuilder()
            .ConCliente("Ana Perez")
            .AgregarProducto("Teclado")
            .AgregarProducto("Mouse")
            .ConEnvioEstandar()
            .Build();
        Mostrar(pedido1);

        var pedido2 = new PedidoBuilder()
            .ConCliente("Luis Gomez")
            .AgregarProducto("Monitor")
            .ConEnvioExpress()
            .Build();
        Mostrar(pedido2);

        // pedido sin productos: Build() lo rechaza
        try
        {
            new PedidoBuilder().ConCliente("Sin Productos").Build();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error esperado: {ex.Message}");
        }
    }

    private static void Mostrar(Pedido pedido)
    {
        Console.WriteLine($"Pedido de {pedido.Cliente}: {string.Join(", ", pedido.Productos)} ({pedido.TipoEnvio})");
    }
}
