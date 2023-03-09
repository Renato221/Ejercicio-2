namespace Ejercicio_2;

class Concesionaria {

    public List<Automovil> lista;
    public int limite;
    public int NumeroActual;

    public Concesionaria(int limite) {

        this.limite = limite;
        this.NumeroActual = 0;
        lista = new List<Automovil>();
    }
    
    public void AgregarAuto(Automovil auto) {


        if(NumeroActual != limite && auto != null) {

            Automovil? AutoEncontrado = lista.Find((autolista)=>autolista.id==auto.id);

            if(AutoEncontrado == null){
                lista.Add(auto);
                this.NumeroActual++;
            }
        }
    }

    public void EliminarAuto(string id) {

        if(NumeroActual != 0){

            Automovil? AutoEncontrado = lista.Find((auto)=>auto.id==id);
            /*
                (auto)=>auto.id==id
                function(Automovil auto){

                    if(auto.id == id) {
                        return auto
                    }
                }
            */
            if(AutoEncontrado != null) {
                lista.Remove(AutoEncontrado);
                this.NumeroActual--;
            }
            
        }
        
    }

    public void MostrarAuto(string id) {

        Automovil? AutoEncontrado = lista.Find((autolista)=>autolista.id==id);

        if(AutoEncontrado != null) {

            Console.WriteLine(AutoEncontrado.ToString());
        }
    }

    public void MostrarAutos() {

        foreach(Automovil a in lista) {

            Console.WriteLine(a.ToString());
        }
    }

    public void VaciarConcesionaria() {

        lista.Clear();
        this.NumeroActual = 0;
    }
}