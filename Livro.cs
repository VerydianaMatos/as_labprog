
public class Livro : ItemBiblioteca
{
    public string Autor { get; private set; } //propiedade dicional

    public Livro(int id, string titulo, string autor) : base(id, titulo) 
    {
        Autor = autor; //construtor
    }

    public void ExibirDescricaoInterna() //metodo adicional
    {
        Console.WriteLine($"Descrição Interna do Livro ({Titulo}): {DescricaoInterna}");
    }
}