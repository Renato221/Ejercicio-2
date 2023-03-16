namespace Ejercicio_2;

class Automovil {

    public string? id;
    public string? marca;
    public string? modelo;
    public int km;
    public double precio;

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