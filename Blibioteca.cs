public class Biblioteca
{
    private List<ItemBiblioteca> colecao; //lista de itembiblioteca

    public Biblioteca() //construtor
    {
        colecao = new List<ItemBiblioteca>();
    }

    public void AdicionarItem(ItemBiblioteca item) // metodo adicionar livro
    {
        colecao.Add(item);
        Console.WriteLine($"Livro '{item.Titulo}' adicionado à biblioteca.");
    }

    public void RemoverItem(ItemBiblioteca item) //metodo para remover
    {
        if (colecao.Remove(item))
        {
            Console.WriteLine($"Item '{item.Titulo}' removido da biblioteca.");
        }
        else
        {
            Console.WriteLine($"Item '{item.Titulo}' não encontrado na biblioteca.");
        }
    }

    public ItemBiblioteca BuscarItemPorTitulo(string titulo) //metodo de busca por título
    {
        return colecao.Find(item => item.Titulo == titulo);
    }

    public ItemBiblioteca BuscarItemPorId(int id) //busca por id
    {
        return colecao.Find(item => item.Id == id);
    }

    public void ExibirTodosOsItens() //exibe todos os itens
    {
        Console.WriteLine("\nItens na biblioteca:");
        foreach (var item in colecao)
        {
            Console.WriteLine($"- {item.Titulo}");
        }
    }
}
