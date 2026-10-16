namespace PatronesCreacionales.Prototype;

public static class PrototypeDemo
{
    public static void Ejecutar()
    {
        var prototipo = new Personaje();
        prototipo.Nombre = "Guerrero";
        prototipo.Vida = 100;
        prototipo.Nivel = 1;
        prototipo.Habilidades = new List<string> { "Golpe", "Escudo" };

        var clon1 = prototipo.Clonar();
        var clon2 = prototipo.Clonar();

        clon1.Vida = 50;
        clon1.Habilidades.Add("Furia");

        Mostrar("Prototipo", prototipo);
        Mostrar("Clon 1", clon1);
        Mostrar("Clon 2", clon2);

        Console.WriteLine($"¿Prototipo y clon 1 son el mismo objeto?: {ReferenceEquals(prototipo, clon1)}");
        Console.WriteLine($"¿Misma lista de habilidades (prototipo y clon 1)?: {ReferenceEquals(prototipo.Habilidades, clon1.Habilidades)}");
        Console.WriteLine($"¿Misma lista de habilidades (clon 1 y clon 2)?: {ReferenceEquals(clon1.Habilidades, clon2.Habilidades)}");
    }

    private static void Mostrar(string titulo, Personaje personaje)
    {
        Console.WriteLine($"{titulo}: {personaje.Nombre}, vida {personaje.Vida}, nivel {personaje.Nivel}, habilidades [{string.Join(", ", personaje.Habilidades)}]");
    }
}
