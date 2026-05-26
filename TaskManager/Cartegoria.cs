namespace TaskManager;

public class Cartegoria
{
    public int CartegoriaID { get; set; }
    public string CartegoriaNome { get; set; }
    public string CartegoriaDescricao { get; set; }


    public Cartegoria(int cartegoriaId, string cartegoriaNome, string cartegoriaDescricao)
    {
        CartegoriaID = cartegoriaId;
        CartegoriaNome = cartegoriaNome;
        CartegoriaDescricao = cartegoriaDescricao;
    }
}