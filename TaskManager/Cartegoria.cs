namespace TaskManager;

public class Categoria
{
    public int CategoriaID { get; private set; }
    public string CategoriaNome { get; private set; }
    public string CategoriaDescricao { get; private set; }
    public SLA SLADACategoria { get; private set; }


    public Categoria(int cartegoriaId, string cartegoriaNome, string cartegoriaDescricao, SLA sla)
    {
        if (string.IsNullOrWhiteSpace(cartegoriaNome))
        {
            throw new ArgumentException("O nome da categoria não pode estar vázio");
        }

        if (string.IsNullOrWhiteSpace(cartegoriaDescricao))
        {
            throw new ArgumentException("A descrição da categoria não pode estar em branco.");
        }

        if (sla == null)
        {
            throw new ArgumentException("A categoria precisa ter um SLA");
        }
        
        CategoriaID = cartegoriaId;
        CategoriaNome = cartegoriaNome;
        CategoriaDescricao = cartegoriaDescricao;
        SLADACategoria = sla;
    }
}