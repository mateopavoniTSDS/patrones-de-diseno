namespace PatronesCreacionales.Builder;

public class PedidoBuilder
{
    private string cliente = "";
    private List<string> productos = new();
    private TipoEnvio tipoEnvio = TipoEnvio.Estandar;

    public PedidoBuilder ConCliente(string cliente)
    {
        this.cliente = cliente;
        return this;
    }

    public PedidoBuilder AgregarProducto(string producto)
    {
        productos.Add(producto);
        return this;
    }

    public PedidoBuilder ConEnvioEstandar()
    {
        tipoEnvio = TipoEnvio.Estandar;
        return this;
    }

    public PedidoBuilder ConEnvioExpress()
    {
        tipoEnvio = TipoEnvio.Express;
        return this;
    }

    public Pedido Build()
    {
        if (string.IsNullOrWhiteSpace(cliente))
        {
            throw new InvalidOperationException("El pedido debe tener un cliente");
        }
        if (productos.Count == 0)
        {
            throw new InvalidOperationException("El pedido debe tener al menos un producto");
        }

        var pedido = new Pedido();
        pedido.Cliente = cliente;
        pedido.Productos = new List<string>(productos);
        pedido.TipoEnvio = tipoEnvio;
        return pedido;
    }
}
