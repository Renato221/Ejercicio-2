namespace Ejercicio_2;

class Concesionaria {

    private List<Automovil> lista;
    private int limite;
    private int nactauto;

    public Concesionaria(int limite) {

        this.limite = limite;
        this.nactauto = 0;
        lista = new List<Automovil>();
    }
    
    public void AgregarAuto(Automovil auto) {

        lista.Add(auto);
        this.nactauto++;
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