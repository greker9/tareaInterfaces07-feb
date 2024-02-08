// Definición de la interfaz
public interface IAnimal
{
    void Sonido();
}

// Clase que implementa la interfaz
public class Perro : IAnimal
{
    public string Nombre { get; set; }
    public string Raza { get; set; }
    public int Edad { get; set; }

    public void Sonido()
    {
        Console.WriteLine("El perro hace: guau guau");
    }
}

// Clase que implementa la interfaz
public class Gato : IAnimal
{
    public string Nombre { get; set; }
    public string Color { get; set; }
    public int Edad { get; set; }

    public void Sonido()
    {
        Console.WriteLine("El gato hace: miau miau");
    }
}

// Clase principal
class Program
{
    static void Main(string[] args)
    {
        Perro miPerro = new Perro() { Nombre = "Firulais", Raza = "Labrador", Edad = 5 };
        Gato miGato = new Gato() { Nombre = "Misifu", Color = "Negro", Edad = 3 };

        Console.WriteLine($"Perro: {miPerro.Nombre}, Raza: {miPerro.Raza}, Edad: {miPerro.Edad}");
        miPerro.Sonido(); // El perro hace: guau guau

        Console.WriteLine($"Gato: {miGato.Nombre}, Color: {miGato.Color}, Edad: {miGato.Edad}");
        miGato.Sonido(); // El gato hace: miau miau
    }
}
