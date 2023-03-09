namespace Ejercicio_2;

class Concesionaria {

    public List<Automovil> lista;
    public int limite;
    public int nactauto;

    public Concesionaria(int limite) {

        this.limite = limite;
        this.nactauto = 0;
        lista = new List<Automovil>();
    }
    
    public void AgregarAuto(Automovil auto) {

        if(nactauto < limite) {
            lista.Add(auto);
            this.nactauto++;
        } else {
            Console.WriteLine("Concesionaria llena!!");
        }
    }

    public void MostrarAuto(Automovil auto) {

        Console.WriteLine(auto.ToString());
    }

    public void EliminarAuto(Automovil auto) {

        int t;

        t = lista.Count();
        lista.Remove(auto);

        if(lista.Count() < t) {
            this.nactauto--;
        }
        
    }

    public void MostrarAutos() {

        foreach(Automovil item in lista) {

            MostrarAuto(item);
        }
    }

    public void VaciarConcesionaria() {

        lista.Clear();
        this.nactauto = 0;
    }
}