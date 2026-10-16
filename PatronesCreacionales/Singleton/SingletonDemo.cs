namespace PatronesCreacionales.Singleton;

public static class SingletonDemo
{
    public static void Ejecutar()
    {
        var config1 = ConfiguracionSistema.Instance;
        var config2 = ConfiguracionSistema.Instance;

        Console.WriteLine($"¿Misma instancia?: {ReferenceEquals(config1, config2)}");

        // el cambio hecho desde config1 se ve desde config2
        config1.NombreAplicacion = "Gestion Deportiva";
        Console.WriteLine($"config1.NombreAplicacion: {config1.NombreAplicacion}");
        Console.WriteLine($"config2.NombreAplicacion: {config2.NombreAplicacion}");
    }
}
