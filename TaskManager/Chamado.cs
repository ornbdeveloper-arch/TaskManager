namespace TaskManager;

public class Chamado
{
    public int ID_Chamados { get; set; }
    public string Chamados_Desc { get; set; }


    public Chamado(int id, string chamados)
    {
        ID_Chamados = id;
        Chamados_Desc = chamados;
    }
}