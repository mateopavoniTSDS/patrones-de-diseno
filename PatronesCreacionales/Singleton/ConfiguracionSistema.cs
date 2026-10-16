namespace PatronesCreacionales.Singleton;

public class ConfiguracionSistema
{
    private static readonly ConfiguracionSistema instance = new();
    private string nombreAplicacion = "Sistema de Gestion";

    private ConfiguracionSistema()
    {
    }

    public static ConfiguracionSistema Instance
    {
        get { return instance; }
    }

    public string NombreAplicacion
    {
        get { return nombreAplicacion; }
        set { nombreAplicacion = value; }
    }
}
