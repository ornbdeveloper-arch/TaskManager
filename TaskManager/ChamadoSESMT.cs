namespace TaskManager;

public class ChamadoSESMT : Chamado
{
    public string Treinamento { get; private set; }
    public string NomeTecnico { get; private set; }

    public ChamadoSESMT(int id, string descricao, string titulo, Usuario usuario, Categoria categoria, string contrato,
        string treinamento, string nomeTecnico)
        : base(id, descricao, titulo, usuario, categoria, contrato)
    {
        Treinamento = treinamento;
        NomeTecnico = nomeTecnico;
    }
}