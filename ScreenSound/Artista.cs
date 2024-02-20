class Artista
{
    private List<Album> albums = new List<Album>();

    public Artista(string nome)
    {
        Nome = nome;
    }
    public String Nome { get; }
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDisografia()
    {
        Console.WriteLine($"Discografia do Artista: {Nome}");
        foreach (Album album in albums) 
        {
            Console.WriteLine($"Album:{album.Nome} (Duração Total: {album.DuracaoTotal} segundos)");
        }
    }
}