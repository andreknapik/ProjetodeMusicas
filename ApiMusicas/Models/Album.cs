namespace ApiMusicas.Models;

public class Album
{
    public string Nome { get ; set;}
    public int AnoLancamento { get ; set;}
    public string CapaUrl { get ; set;}
    public Artista Artista { get ; set;}
}
