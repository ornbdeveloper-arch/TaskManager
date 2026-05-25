// Classe criada pra construir os chamados usando Objetos.
namespace TaskManager;

public class Chamado
{
    // Atributos da Classe.
    public int ID_Chamados { get; set; }
    public string Chamados_Desc { get; set; }
    public string Titulo_Chamados { get; set; }
    public string SLA_Chamado { get; set; }


    // Métodos da Classe.
    public Chamado(int id, string chamados, string slaChamado, string tituloChamado)
    {
        ID_Chamados = id;
        Chamados_Desc = chamados;
        SLA_Chamado = slaChamado;
        Titulo_Chamados = tituloChamado;
    }
}