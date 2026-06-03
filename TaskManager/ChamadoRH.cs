namespace TaskManager;

public class ChamadoRH : Chamado
{
    public string NomeCompleto { get; private set; }
    public string CPF { get; private set; }
    public string CEP { get; private set; }
    public string Cidade { get; private set; }
    public string Estado { get; private set; }

    public ChamadoRH(int id, string descricao, string titulo, Usuario usuario, Categoria categoria, string contrato,
        string nomeCompleto, string cpf,string cep, string cidade, string estado)
        : base(id, descricao, titulo, usuario, categoria, contrato)
    {
        NomeCompleto = nomeCompleto;
        CPF = cpf;
        CEP = cep;
        Cidade = cidade;
        Estado = estado;
    }
}