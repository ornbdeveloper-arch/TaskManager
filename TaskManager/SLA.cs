namespace TaskManager;


// Criação da classe SLA.
public class SLA
{
    public int SLAID { get; set; }
    public string SLANome { get; set; }
    public byte TempoMinutos { get; set; }
    public short TempoHoras { get; set; }

    public SLA(int slaid, string slaNome, byte tempoMinutos, short tempoHoras)
    {
        SLAID = slaid;
        SLANome = slaNome;
        TempoMinutos = tempoMinutos;
        TempoHoras = tempoHoras;
    }
}