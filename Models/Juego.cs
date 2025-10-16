public class Juego{
    public List<Palabra> ListPalabra {get; set;}
    public List<Usuario> Jugadores {get; set;}
    public Usuario JugadorActual {get; set; }
    public string PalabraActual {get; private set; }
}