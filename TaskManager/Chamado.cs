// Classe criada pra construir os chamados usando Objetos.
namespace TaskManager;

public class Chamado
{
    private string _Titulo;

    private string Descricao;
    // Atributos da Classe.
    public int ID_Chamados { get; set; }
    public string Titulo_Chamados { get
        {
            return _Titulo;
        }
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("O Título não pode estar vazio.");
            }
            else
            {
                _Titulo = value;
            }
        } }

    public string Chamados_Desc
    {
        get
        {
            return Descricao;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("O chamado não pode estar vazio.");
            }
            else
            {
                Descricao = value;
            }
        }
    }

    public Usuario usuarioLogado { get; set; }
    public Categoria CartegoriaDoChamado { get; set; }
  


    // Métodos da Classe.
    // Deixamos apenas os 6 parâmetros que importam, sem aquela string solta de SLA
    public Chamado(int id, string descricao, string titulo, Usuario usuario, Categoria cartegoria)
    {
        // Métodos da classe Chamado.
        ID_Chamados = id;
        Titulo_Chamados = titulo;
        Chamados_Desc = descricao;
        usuarioLogado = usuario;
        CartegoriaDoChamado = cartegoria;
    }
}