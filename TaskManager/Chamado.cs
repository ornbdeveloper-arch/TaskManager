// Classe criada pra construir os chamados usando Objetos.
namespace TaskManager;

public class Chamado
{
    public void IniciarAtendimento()
    {
        if (Status != StatusChamado.Aberto)
            throw new InvalidCastException("Só é possível iniciar um chamado que está aberto.");
            
        Status = StatusChamado.EmAndamento;    
        
    }

    public void FecharChamado()
    {
        if (Status != StatusChamado.EmAndamento)
            throw new InvalidOperationException("Só é possível fechar chamados que estejam em atendimento.");
            
        Status = StatusChamado.Fechado;    
        
    }
    
    public StatusChamado Status { get; private set; }
    
    private string _Titulo;

    private string Descricao;
    
    public string Contrato { get;  private set; }
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
    public Chamado(int id, string descricao, string titulo, Usuario usuario, Categoria cartegoria, string contrato)
    {
        if (string.IsNullOrWhiteSpace(contrato))
        {
            throw new ArgumentException("O contrato não pode estar vazio.");
        }
        // Métodos da classe Chamado.
        ID_Chamados = id;
        Titulo_Chamados = titulo;
        Chamados_Desc = descricao;
        usuarioLogado = usuario;
        CartegoriaDoChamado = cartegoria;
        Status = StatusChamado.Aberto;
        Contrato = contrato;
    }
    
}