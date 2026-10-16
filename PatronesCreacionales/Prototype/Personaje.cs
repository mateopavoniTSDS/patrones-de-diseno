namespace PatronesCreacionales.Prototype;

public class Personaje : IPrototype<Personaje>
{
    private string nombre = "";
    private int vida;
    private int nivel;
    private List<string> habilidades = new();

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Vida
    {
        get { return vida; }
        set { vida = value; }
    }

    public int Nivel
    {
        get { return nivel; }
        set { nivel = value; }
    }

    public List<string> Habilidades
    {
        get { return habilidades; }
        set { habilidades = value; }
    }

    public Personaje Clonar()
    {
        var clon = new Personaje();
        clon.Nombre = Nombre;
        clon.Vida = Vida;
        clon.Nivel = Nivel;
        // lista nueva para que el clon no comparta habilidades
        clon.Habilidades = new List<string>(Habilidades);
        return clon;
    }
}
