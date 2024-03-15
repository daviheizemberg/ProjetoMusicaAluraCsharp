//Banda queen = new Banda("Queen");


//Album albumDoQueen = new Album("A night at the opera");

//Musica musica1 = new Musica(queen, "Love of my life")
//{
//    Duracao = 213,
//    Disponivel = true,
//};

//Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
//{
//    Duracao = 354,
//    Disponivel = false,
//};

//albumDoQueen.Adicionarmusica(musica1);
//albumDoQueen.Adicionarmusica(musica2);
//queen.AdicionarAlbum(albumDoQueen);
//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//albumDoQueen.ExibirMusicasDoAlbum();
//queen.ExibirDiscografia();

Episodio ep1 = new(2, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Zeca");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new(1, "Técnicas de aprendizado", 67);
ep2.AdicionarConvidados("Davi");
ep2.AdicionarConvidados("Henrique");

Podcast podcast = new("Podzeca", "Zeca");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);

podcast.ExibirDetalhes();