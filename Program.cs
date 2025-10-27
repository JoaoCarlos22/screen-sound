using ScreenSound.Menus;
using ScreenSound.Models;

// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
Dictionary<string, Artista> artistas = new();
Dictionary<int, Menu> menu = new()
{
    { 1, new RegistrarArtista() },
    { 2, new ListarArtistas() },
    { 3, new AdicionarAlbum() },
    { 4, new AvaliarArtista() },
    { 5, new AvaliarAlbum() },
    { 6, new ExibirDetalhes() }
};

void ExibirMensagemBoasVindas()
{
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirMenu()
{
    ExibirMensagemBoasVindas();
    Console.WriteLine("\n1 - registrar um artista");
    Console.WriteLine("2 - listar artistas");
    Console.WriteLine("3 - adicionar álbum a um artista");
    Console.WriteLine("4 - avaliar um artista");
    Console.WriteLine("5 - avaliar um álbum");
    Console.WriteLine("6 - exibir detalhes de um artista");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcaoEscolhidaNumerica == -1)
    {
        Console.WriteLine("Tchau tchau :)");
        return;
    }

    if (!menu.ContainsKey(opcaoEscolhidaNumerica))
    {
        Console.WriteLine("Opção inválida");
        VoltarMenu();
        return;
    }
    
    menu[opcaoEscolhidaNumerica].Exibir(artistas);
    VoltarMenu();
}

void VoltarMenu()
{
    Console.WriteLine("Digite alguma tecla para voltar ao menu.");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

ExibirMenu();