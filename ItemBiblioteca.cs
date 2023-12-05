public abstract class ItemBiblioteca
{
    public int Id { get; private set; } //propiedades
    public string Titulo { get; private set; }
    protected string DescricaoInterna { get; set; }

    protected ItemBiblioteca(int id, string titulo) //construtor
    {
        Id = id;
        Titulo = titulo;
        DescricaoInterna = "Descrição padrão";
    }
}