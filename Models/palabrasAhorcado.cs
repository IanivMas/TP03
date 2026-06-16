namespace TP03.Models;

public class palabrasAhorcado
{
    private List<string> palabras {get; set;} ;
    public palabrasAhorcado()
    {

        this.palabras = new List<string>{"MIERCOLES", "COMPUTADORA", "HIPOPOTAMO", "PRESIDENTE", "DEPARTAMENTO", "DEPARTAMENTO", "ABECEDARIO", "BIBLIOTECA", "IMAGINACIÓN", "ESPECTÁCULO", "BIODIVERSIDAD" };
    }     
    public string devolverPalabra()
    {
        Random rnd = new Random();
        int i = rnd.Next(0,palabras.Count); 
        string palabraElegida = palabras[i];
        return palabraElegida;
    }

}