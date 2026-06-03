namespace TaskManager;

public class ChamadoJuridico : Chamado
{
    public string Nome { get; private set; }
    public string CPF { get; private set; }
    public string NumeroProcesso { get; private set; }
    public string Licitacao { get; private set; }

    public ChamadoJuridico(int id, string descricao, string titulo, Usuario usuario, Categoria categoria,
        string contrato,  string nome, string cpf, string numeroProcesso, string licitacao)
        : base(id, descricao, titulo, usuario, categoria, contrato)
    {
        Nome = nome;
        CPF = cpf;
        NumeroProcesso = numeroProcesso;
        Licitacao = licitacao;
    }
}