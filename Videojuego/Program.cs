// See https://aka.ms/new-console-template for more information

using Videojuego;

class Program
{
    static void Main(string[] args)
    {
        Personaje Iktan = new Personaje
        {
            Nombre = "Guerrero",
            Vida = 100,
            Tipo = Agua,
            Ataque = 75,
            Defensa = 50,
        };

        Console.WriteLine("--- Datos del Personaje ---");
        Console.WriteLine($"Nombre: {Iktan.Nombre}");
        Console.WriteLine($"Vida: {Iktan.Vida}");
        Console.WriteLine($"Tipo: {Iktan.Tipo}");
        Console.WriteLine($"Ataque: {Iktan.Ataque}");
        Console.WriteLine($"Defensa: {Iktan.Defensa}");
    }
}