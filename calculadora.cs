namespace EspacioCalculadora {
public class calculadora {
    private double dato = 0;
    public double Dato { get => dato; set => dato = value; }

    public void sumar(double termino) {
        this.Dato += termino;
    }
    
    public void restar(double termino) {
        this.Dato -= termino;
    }
    public void multiplicar(double termino) {
        this.Dato *= termino; // Dato *= termino
    }
    public void dividir(double termino) {
        this.Dato /= termino;
    }
    public void limpiar() {
        this.Dato = 0;
    } 
    public double Resultado {
        get {
            return(dato);
        }
    }
}
}