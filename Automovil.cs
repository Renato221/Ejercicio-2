namespace Ejercicio_2;

class Automovil {

    private string id;
    private string marca;
    private string modelo;
    private int km;
    private double precio;

    public Automovil(string id, string marca, string modelo, int km, double precio) {

        this.id = id;
        this.marca = marca;
        this.modelo = modelo;
        this.km = km;
        this.precio = precio;
    }
    
    public override string ToString() {

        return $"Id: {id}, Marca: {marca}, Modelo: {modelo}, Km: {km}, Precio: {precio}";
    }

}