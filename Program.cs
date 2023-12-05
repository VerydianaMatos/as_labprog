iblioteca biblioteca = new Biblioteca(); //instancia de biblioteca

while (true) //menu 
    {
        Console.WriteLine("\n=== Menu ===");
        Console.WriteLine("1. Adicionar Livro");
        Console.WriteLine("2. Remover Livro");
        Console.WriteLine("3. Buscar Livro por Título");
        Console.WriteLine("4. Exibir Todos os Itens na Biblioteca");
        Console.WriteLine("5. Sair");
        Console.Write("Escolha uma opção: ");
        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                AdicionarLivro(biblioteca);
                break;
            case "2":
                RemoverLivro(biblioteca);
                break;
            case "3":
                BuscarLivroPorTitulo(biblioteca);
                break;
            case "4":
                biblioteca.ExibirTodosOsItens();
                break;
            case "5":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
            }
        }


static void AdicionarLivro(Biblioteca biblioteca) //funcao para add livro a bibli
{
    Console.Write("Digite o ID do livro: ");
    int idLivro = int.Parse(Console.ReadLine());

    Console.Write("Digite o título do livro: ");
    string tituloLivro = Console.ReadLine();

    Console.Write("Digite o autor do livro: ");
    string autorLivro = Console.ReadLine();

    Livro novoLivro = new Livro(id: idLivro, titulo: tituloLivro, autor: autorLivro);
    biblioteca.AdicionarItem(novoLivro);
}

static void RemoverLivro(Biblioteca biblioteca)//funcao para remover
{
    Console.Write("Digite o título do livro a ser removido: ");
    string tituloLivro = Console.ReadLine();

    ItemBiblioteca livroEncontrado = biblioteca.BuscarItemPorTitulo(tituloLivro);

    if (livroEncontrado != null)
    {
        biblioteca.RemoverItem(livroEncontrado);
    }
    else
    {
        Console.WriteLine("Livro não encontrado.");
    }
}

static void BuscarLivroPorTitulo(Biblioteca biblioteca)//busca livro por titulo
{
    Console.Write("Digite o título do livro a ser buscado: ");
    string tituloLivro = Console.ReadLine();

    ItemBiblioteca livroEncontrado = biblioteca.BuscarItemPorTitulo(tituloLivro);

    if (livroEncontrado != null)
    {
        ((Livro)livroEncontrado).ExibirDescricaoInterna();
    }
    else
    {
        Console.WriteLine("Livro não encontrado.");
    }
}

