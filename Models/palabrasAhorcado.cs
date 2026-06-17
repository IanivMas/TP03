namespace TP03.Models;

public class palabrasAhorcado
{
    BD BD = new BD ();
    private List<string> palabras {get; set;} 
    public palabrasAhorcado()
    {

        this.palabras = BD.agregarPalabras();
    }     
    public string devolverPalabra()
    {
        Random rnd = new Random();
        int i = rnd.Next(0,palabras.Count); 
        string palabraElegida = palabras[i];
        return palabraElegida;
    }

}