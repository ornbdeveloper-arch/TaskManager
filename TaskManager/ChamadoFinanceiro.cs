namespace TaskManager;

public class ChamadoFinanceiro : Chamado
{
    public string Valores {get; private set;}
    public string FechamentoFolha {get; private set;}
    public string Debitos {get; private set;}
    public string Creditos {get; private set;}

    public ChamadoFinanceiro(int id, string descricao, string titulo, Usuario usuario, Categoria categoria,
        string contrato, string valores, string fechamentoFolha, string debitos, string creditos)
        : base(id, descricao, titulo, usuario, categoria, contrato)
    {
        Valores = valores;
        FechamentoFolha = fechamentoFolha;
        Debitos = debitos;
        Creditos = creditos;
    }
}