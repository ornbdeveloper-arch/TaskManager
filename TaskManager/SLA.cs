namespace TaskManager;


// Criação da classe SLA.
public class SLA
{
    public int SLAID { get; private set; }
    public string SLANome { get; private set; }
    public byte TempoMinutos { get; private set; }
    public short TempoHoras { get; private set; }

    public SLA(int slaid, string slaNome, byte tempoMinutos, short tempoHoras)
    {
        
        SLAID = slaid;
        SLANome = slaNome;
        TempoMinutos = tempoMinutos;
        TempoHoras = tempoHoras;
    }
}