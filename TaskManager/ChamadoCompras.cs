namespace TaskManager;

public class ChamadoCompras : Chamado
{
    public string NomeProduto { get; private  set; }
    public string QuantidadeProduto { get; private  set; }
    public string ValorProduto { get; private  set; }
    public string Parceiro { get; private  set; }

    public ChamadoCompras(int id, string descricao, string titulo, Usuario usuario, Categoria categoria,
        string contrato, string nomeProduto, string quantidadeProduto, string valorProduto, string parceiro)
        : base(id, descricao, titulo, usuario, categoria, contrato)
    {
        NomeProduto = nomeProduto;
        QuantidadeProduto = quantidadeProduto;
        ValorProduto = valorProduto;
        Parceiro = parceiro;
    }
            
}