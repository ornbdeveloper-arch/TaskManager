namespace TaskManager;

public class DadosDoSistema
{
    public static List<SLA> CarregarSLAs()
    {
        List<SLA> slas = new List<SLA>();
        slas.Add(new SLA(1, "Baixo", (byte)0, (short)48));
        slas.Add(new SLA(2, "Médio", (byte)0, (short)24));
        slas.Add(new SLA(3, "Alto", (byte)0, (short)6));
        slas.Add(new SLA(4, "Crítico", (byte)0, (short)2));

        return slas;
    }

    public static List<Categoria> CarregarCategoria()
    {
        List<SLA> slas = CarregarSLAs();
        List<Categoria> categorias = new List<Categoria>();
        categorias.Add(new Categoria(1, "Hardware", "Problemas com computador", slas[0]));
        categorias.Add(new Categoria(2, "Software", "Problemas com sistema", slas[1]));
        categorias.Add(new Categoria(3, "Rede", "Problemas com internet", slas[2]));
        categorias.Add(new Categoria(4, "Problemas gerais", "Problemas generalizados", slas[3]));
        return categorias;
    }
}