// Início do sistema; Inicialização das dependências do sistema.
namespace TaskManager;
using System;
using System.Collections.Generic; 

public class TaskManager // Criação da classe principal da aplicação.
{
    public static void Main(string[] args)
    {
        // Cabeçalho.
        Console.WriteLine("==============================");
        Console.WriteLine("Task Manager v1.1");
        Console.WriteLine("===============================");
        
        int op; // Inicialização da variável de opção.
        int idChamado = 1; // Inicialização da variável de ID
        List<Chamado> listaDoSistema = new List<Chamado>(); // Criação da lista de chamados.

        do
        {
            // Cabeçalho; Opções de uso.
            Console.WriteLine("\nEscolha uma opção: ");
            Console.WriteLine("1. Adicionar um Chamado.");
            Console.WriteLine("2. Listar Chamados.");
            Console.WriteLine("3. Remover um Chamado.");
            Console.WriteLine("4. Sair.");
            
            op = Convert.ToInt32(Console.ReadLine());
            
            // Início das condicionais baseado na opção escolhida, futuramente mudar para estrutura de Switch.
            if (op == 1)
            {
                Console.WriteLine("Digite o chamado: ");
                var chamado = Console.ReadLine();
                Console.WriteLine("Digite um título pro chamado: ");
                var tituloChamado = Console.ReadLine();
                Console.WriteLine("Digite a prioridade do chamado: ");
                var slaChamado = Console.ReadLine();
                
                if (chamado != null && chamado != "") // Validaçao garantindo que o chamado não está vazio.
                {
                    // Criação do objeto do chamado e adição a lista de chamados.
                    Chamado novoChamado = new Chamado(idChamado, chamado, slaChamado, tituloChamado);
                    listaDoSistema.Add(novoChamado);
                    
                    idChamado++;  // Autoincrement do ID único do chamado.
                    Console.WriteLine("Chamado adicionado com sucesso!");
                }
            } 
            else if (op == 2)
            {
                Console.WriteLine("\nExibindo Chamados Abertos: ");
                if (listaDoSistema.Count == 0) // Validação de se existem chamados abertos ou não.
                {
                    Console.WriteLine("Nenhum chamado aberto.");
                }
                else
                {
                    for (int i = 0; i < listaDoSistema.Count; i++) // Loop que exibe cada objeto de chamado baseado no índice.
                    {
                        Console.WriteLine($"ID: {listaDoSistema[i].ID_Chamados} - {listaDoSistema[i].Titulo_Chamados}\n{listaDoSistema[i].Chamados_Desc}\n{listaDoSistema[i].SLA_Chamado}");
                    }
                }
            } 
            else if (op == 3)
            {
                Console.WriteLine("\nRemover chamado:\n Informe o ID");
                int idRemover = Convert.ToInt32(Console.ReadLine());
                bool encontrado = false;
                
                for (int i = 0; i < listaDoSistema.Count; i++)
                {
                    if (listaDoSistema[i].ID_Chamados == idRemover)
                    {
                        listaDoSistema.RemoveAt(i);
                        Console.WriteLine("Removido com Sucesso!");
                        encontrado = true;
                        break; 
                    }   
                }

                if (!encontrado) // Validação para saber se existe algum chamado com o ID mencionado.
                {
                    Console.WriteLine("Nenhum chamado encontrado com esse ID.");
                }
            }
        } while (op != 4); // Saída do app.
    }
}

// Fim do sistema.