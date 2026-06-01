namespace TaskManager;

public class Usuario
{
    public int UsuarioID { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }



    public Usuario(int usuarioId, string nome, string email)
    {
        if (string.IsNullOrEmpty(nome))
        {
            throw new ArgumentException("O nome não pode estar vazio.");
        }

        if (string.IsNullOrEmpty(email))
        {
            throw new ArgumentException("O E-mail não pode estar vazio.");
        }

        if (!email.Contains("@"))
        {
            throw new ArgumentException("O email informado é inválido.");
        }
        UsuarioID = usuarioId;
        Nome = nome;
        Email = email;
    }
    
}