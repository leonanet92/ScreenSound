//variaveis Globais
//List<string> listaBanda = new List<string> {"Banda 1","Banda 2","Banda 3" };
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link park", new List<int> { 10, 8, 9 });
bandasRegistradas.Add("Guns", new List<int>());
//Funcções
void Logo()
{
    Console.Clear();
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
}
void Menu()
{
    Logo();
    Console.WriteLine(@"Digite os Numero para acessar o menu
 1 - Registrar uma banda
 2 - Motrar todas as bandas
 3 - Avalir uma banda
 4 - Exibir a media de uma banda
-1 - Sair");


    String escolha = Console.ReadLine()!;
    int escolhanumero = int.Parse(escolha);

    switch (escolhanumero)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MotrarBanda();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibeMediaBanda();
            break;
        case -1:
            Console.WriteLine("Obrigado e Ate mais");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    TituloDoMenu("Registro de bandas");
    Console.WriteLine("Digite o nome de uma banda:");
    String nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!\nParabens!!!!!!");
    Thread.Sleep(2000);

    Menu();
}
void MotrarBanda()
{
    Console.Clear();
    TituloDoMenu("Mostrar Bandas");
    Console.WriteLine("Todas as bandas registrada: ");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.ReadKey();
    Menu();
}
void AvaliarBanda()
{
    Console.Clear();
    TituloDoMenu("Avaliar de bandas");

    Console.ReadKey();
    Menu();
}
void ExibeMediaBanda()
{
    Console.Clear();
    TituloDoMenu("Medias das bandas");

    Console.ReadKey();
    Menu();
}
void TituloDoMenu(String tituloMenu)
{
    int quantidadeChar = tituloMenu.Length;
    String asteriscos = String.Empty.PadLeft(quantidadeChar, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(tituloMenu);
    Console.WriteLine(asteriscos + "\n");

}

//Programa

Menu();