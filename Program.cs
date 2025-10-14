using ScreenSound.Menus;
using ScreenSound.Models;

// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
Dictionary<string, Banda> bandas = new();
Dictionary<int, Menu> menu = new()
{
    { 1, new RegistrarBanda() },
    { 2, new ListarBandas() },
    { 3, new AvaliarBanda() },
    { 4, new ExibirMediaBanda() },
    { 5, new ExibirDetalhes() }
};

void ExibirMensagemBoasVindas()
{
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirMenu()
{
    ExibirMensagemBoasVindas();
    Console.WriteLine("\n1 - registrar uma banda");
    Console.WriteLine("2 - listar bandas");
    Console.WriteLine("3 - avaliar uma banda");
    Console.WriteLine("4 - exibir a média de uma banda");
    Console.WriteLine("5 - exibir detalhes de uma banda");
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
    
    menu[opcaoEscolhidaNumerica].Exibir(bandas);
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