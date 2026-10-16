namespace PatronesCreacionales.Builder;

public enum TipoEnvio
{
    Estandar,
    Express
}

public class Pedido
{
    private string cliente = "";
    private List<string> productos = new();
    private TipoEnvio tipoEnvio = TipoEnvio.Estandar;

    // solo se crea desde el builder
    internal Pedido()
    {
    }

    public string Cliente
    {
        get { return cliente; }
        set { cliente = value; }
    }

    public List<string> Productos
    {
        get { return productos; }
        set { productos = value; }
    }

    public TipoEnvio TipoEnvio
    {
        get { return tipoEnvio; }
        set { tipoEnvio = value; }
    }
}
