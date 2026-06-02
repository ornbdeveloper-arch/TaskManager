namespace TaskManager;

public class ChamadoFrota : Chamado
{
    public string Combustivel { get; private set; }
    public string Motorista { get; private set; }
    public string Unidade { get; private set; }
    public string Placa { get; private set; }
    public int KM { get; private set; }

    public ChamadoFrota(int id, string descricao, string titulo, Usuario usuario, Categoria categoria,
        string combustivel, string motorista, string unidade, string placa, int km, string contrato)
        : base(id, descricao, titulo, usuario, categoria, contrato)
    {
        Combustivel = combustivel;
        Motorista = motorista;
        Unidade = unidade;
        Placa = placa;
        KM = km;
    }
}