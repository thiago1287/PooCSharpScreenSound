Episodio ep1 = new(1, "Como foi escrever Atravessei São Paulo", 36);

ep1.AdicionarConvidados("Eco");
ep1.AdicionarConvidados("Sobs");

Episodio ep2 = new(2, "Album offduzz", 55);

ep2.AdicionarConvidados("Eco");
ep2.AdicionarConvidados("Sobs");
ep2.AdicionarConvidados("Killua");

Podcast podcast = new("'Por trás dos Hits'", "Igão");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();