// See https://aka.ms/new-console-template for more information
static void Menu()
{
    Console.Clear();
    Console.WriteLine("Qual opção você deseja?");
    Console.WriteLine("1. Abrir Arquivo");
    Console.WriteLine("2. Criar Arquivo");
    Console.WriteLine("3. Editar Arquivo");
    Console.WriteLine("4. Salvar Arquivo");
    Console.WriteLine("0. Exit");
    short option = short.Parse(Console.ReadLine());
    switch (option)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Criar(); break;
        case 3: Editar(); break;
        default: Menu(); break;
    }
}
static void Abrir()
{
    Console.Clear();
    Console.WriteLine("Qual o caminho do arquivo?");
    string path = Console.ReadLine();
    using (var file = new StreamReader(path))
    {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
    }
    Console.WriteLine("");
    Console.ReadLine();
    Menu();
}
static void Criar()
{
    Console.Clear();
    Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
    Console.WriteLine("----------------");
    string text = "";
    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    } while (Console.ReadKey().Key != ConsoleKey.Escape);
    Console.WriteLine("----------------");
    Console.WriteLine("Qual o caminho para salvar o arquivo?");
    var path = Console.ReadLine();
    using (var file = new StreamWriter(path))
    {
        file.Write(text);
    }
    Salvar(text);
    Console.WriteLine($"Arquivo {path} salvo com sucesso!");
    Console.ReadLine();
    Menu();
}
static void Editar()
{
    Console.Clear();
    Console.WriteLine("Digete seu texto abaixo (ESC para sair)");
    Console.WriteLine("----------------");
    string text = "";
    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    } while (Console.ReadKey().Key != ConsoleKey.Escape);


    Salvar(text);
    

    Menu();
}
static void Salvar(string text)
{
    Console.Clear();
    Console.WriteLine("Qual o caminho para salvar o arquivo?");
    var path = Console.ReadLine();
    using (var file = new StreamWriter(path))
    {
        file.Write(text);
    }
    Console.WriteLine($"Arquivo {path} salvo com sucesso!");
    Console.ReadLine();
    Menu();
}
Menu();