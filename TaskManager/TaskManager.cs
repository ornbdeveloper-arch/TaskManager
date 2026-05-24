namespace TaskManager;
using System;
using System.Collections.Generic; // Garante que a List funcionará sem erros

public class TaskManager
{
    public static void Main(string[] args)
    {
        Console.WriteLine("==============================");
        Console.WriteLine("Task Manager v1.1");
        Console.WriteLine("===============================");
        
        int op;
        int idChamado = 1;
        List<Chamado> listaDoSistema = new List<Chamado>();

        do
        {
            Console.WriteLine("\nEscolha uma opção: ");
            Console.WriteLine("1. Adicionar um Chamado.");
            Console.WriteLine("2. Listar Chamados.");
            Console.WriteLine("3. Remover um Chamado.");
            Console.WriteLine("4. Sair.");
            
            op = Convert.ToInt32(Console.ReadLine());
            
            if (op == 1)
            {
                Console.WriteLine("Digite o chamado: ");
                var chamado = Console.ReadLine();
                
                if (chamado != null && chamado != "")
                {
                    Chamado novoChamado = new Chamado(idChamado, chamado);
                    listaDoSistema.Add(novoChamado);
                    
                    idChamado++; // Só incrementa se o chamado realmente foi criado
                    Console.WriteLine("Chamado adicionado com sucesso!");
                }
            } 
            else if (op == 2)
            {
                Console.WriteLine("\nExibindo Chamados Abertos: ");
                if (listaDoSistema.Count == 0)
                {
                    Console.WriteLine("Nenhum chamado aberto.");
                }
                else
                {
                    for (int i = 0; i < listaDoSistema.Count; i++)
                    {
                        Console.WriteLine($"ID: {listaDoSistema[i].ID_Chamados} - {listaDoSistema[i].Chamados_Desc}");
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

                if (!encontrado)
                {
                    Console.WriteLine("Nenhum chamado encontrado com esse ID.");
                }
            }
        } while (op != 4);
    }
}