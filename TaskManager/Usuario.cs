namespace TaskManager;

public class Usuario
{
    public int UsuarioID { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }



    public Usuario(int usuarioId, string nome, string email)
    {
        UsuarioID = usuarioId;
        Nome = nome;
        Email = email;
    }
    
}