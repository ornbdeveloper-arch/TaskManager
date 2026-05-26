// Classe criada pra construir os chamados usando Objetos.
namespace TaskManager;

public class Chamado
{
    // Atributos da Classe.
    public int ID_Chamados { get; set; }
    public string Titulo_Chamados { get; set; }
    public string Chamados_Desc { get; set; }
    public Usuario usuarioLogado { get; set; }
    public Cartegoria CartegoriaDoChamado { get; set; }
    public SLA SLADoChamado { get; set; }


    // Métodos da Classe.
    // Deixamos apenas os 6 parâmetros que importam, sem aquela string solta de SLA
    public Chamado(int id, string descricao, string titulo, Usuario usuario, Cartegoria cartegoria, SLA sla)
    {
        // Métodos da classe Chamado.
        ID_Chamados = id;
        Titulo_Chamados = titulo;
        Chamados_Desc = descricao;
        usuarioLogado = usuario;
        CartegoriaDoChamado = cartegoria;
        SLADoChamado = sla;
    }
}