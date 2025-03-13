using Aula11OOJogoRPG;

Console.WriteLine("Jogo RPG!");

//Carregar as armas do jogo.
List<Arma> armas = new List<Arma>();
armas.Add(new Arma("Faca", 5, 10));
armas.Add(new Arma("Espada", 7, 12));
armas.Add(new Arma("Katana", 1, 30));

//Carregar os monstros.
List<Monstro> monstros = new List<Monstro>();
monstros.Add(new Monstro("Troll", 18, 55, 55));
monstros.Add(new Monstro("Orc", 22, 67, 67));
monstros.Add(new Monstro("Baby Dragon", 40, 70, 70));
monstros.Add(new Monstro("Dragon", 85, 100, 100));

//Carregar o jogador.
Jogador objJogador = new Jogador(300, 300);

//Monstro fixo.
objJogador.MonstroAtual = monstros[0];

do
{
    Console.WriteLine();
    Console.WriteLine("Dados do jogador:");
    Console.WriteLine($"Vida: {objJogador.VidaAtual}/{objJogador.VidaMax}");

    Console.WriteLine();
    Console.WriteLine("Dados do monstro:");
    Console.WriteLine($"Nome: {objJogador.MonstroAtual.NomeMonstro}");
    Console.WriteLine($"Vida: {objJogador.MonstroAtual.VidaAtual}" + $"/{objJogador.MonstroAtual.VidaMax}");

    Console.WriteLine();
    Console.WriteLine("Escolha a arma:");
    Console.WriteLine("0 - Faca.");
    Console.WriteLine("1 - Espada.");
    Console.WriteLine("2 - Katana");

    int opcaoArma = Convert.ToInt32(Console.ReadLine());

    objJogador.ArmaAtual = armas[opcaoArma];

    int dano = objJogador.AtacarMonstro();
    Console.WriteLine($"Dano causado ao {objJogador.MonstroAtual.NomeMonstro}: {dano}");
    Console.ReadLine();

    int danoSofrido = objJogador.SerAtacado();
    Console.WriteLine($"O monstro te tirou: {danoSofrido} de vida.");

    Console.ReadLine();

    Console.Clear();

}while (true);