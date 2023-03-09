namespace Ejercicio_2;

class Program {

    static void Main(string[] args) {

        Concesionaria concesionaria = new Concesionaria(15);
        Automovil auto = new Automovil("XXX", "Pirata", "001", 300000, 99.99);
        Automovil auto2 = new Automovil("XX1", "Pirata", "002", 300000, 99.98);
        Automovil auto3 = new Automovil("XX2", "Pirata", "003", 300000, 99.95);
        concesionaria.AgregarAuto(auto);
        concesionaria.AgregarAuto(auto2);
        concesionaria.AgregarAuto(auto3);
        
        concesionaria.MostrarAuto(auto);
        Console.WriteLine("1-------------------------------------");
        concesionaria.MostrarAutos();
        Console.WriteLine("2-------------------------------------");
        concesionaria.EliminarAuto(auto3);
        concesionaria.MostrarAutos();
        Console.WriteLine("3-------------------------------------");
        concesionaria.VaciarConcesionaria();
        concesionaria.MostrarAutos();
        Console.WriteLine("4_____________________________________");
    }
}
