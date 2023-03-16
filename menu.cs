namespace Ejercicio_2;

class Menu{

    Concesionaria concesionaria = new Concesionaria(10);
    public bool ShowMenu() {

        Console.Clear();
        Console.WriteLine("Seleccione una opción: ");
        Console.WriteLine("[1] Agregar automovil");
        Console.WriteLine("[2] Eliminar Automovil ");
        Console.WriteLine("[3] Buscar Automovil ");
        Console.WriteLine("[4] Listar todos ");
        Console.WriteLine("[5] Salir");
        Console.Write("Opcion: ");
        
        switch(Console.ReadLine()){

            case "1":
                AgregarAutomovil();
                Console.ReadLine();
                return true;
            case "2":
                EliminarAutomovil();
                return true;
            case "3":
                BuscarAutomovil();
                Console.ReadLine();
                return true;
            case "4":
                concesionaria.MostrarAutos();
                Console.ReadLine();
                return true;
            case "5":
                Console.Clear();
                return false;
            default:
                return true;
        }
    }

    public void AgregarAutomovil() {

        string? id, marca, modelo, km, precio;

        Console.Clear();
        Console.WriteLine("Creando nuevo Automovil...");
        Console.Write("ID: ");
        id = Console.ReadLine();
        Console.Write("Marca: ");
        marca = Console.ReadLine();
        Console.Write("Modelo: ");
        modelo = Console.ReadLine();
        Console.Write("KM: ");
        km = Console.ReadLine();
        Console.Write("Precio: ");
        precio = Console.ReadLine();

        Automovil nuevo = new Automovil(id, marca, modelo, int.Parse(km), double.Parse(precio));

        concesionaria.AgregarAuto(nuevo);
        Console.WriteLine("Automovil Agregado correctamente");
    }
    public void EliminarAutomovil() {

        string? id;
        Console.Write("ID: ");
        id = Console.ReadLine();
        concesionaria.EliminarAuto(id);
    }
    public void BuscarAutomovil(){

        string? id;
        Console.Write("ID: ");
        id = Console.ReadLine();
        concesionaria.MostrarAuto(id);
    }
}