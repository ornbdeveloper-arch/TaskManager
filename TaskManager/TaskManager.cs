namespace TaskManager;
using System;


public class TaskManager
{
    public static void Main(string[] args)
    {
        Console.WriteLine("==============================");
        Console.WriteLine("Task Manager v1.0");
        Console.WriteLine("===============================");

        List<int> ID = new List<int>();
        List<string> chamados = new List<string>();
        int op = 0;


        do
        {
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1. Adicionar um Chamado.");
            Console.WriteLine("2. Listar Chamados.");
            Console.WriteLine("3. Remover um Chamado.");
            op = Convert.ToInt32(Console.ReadLine());
            if (op == 1)
            {
                Console.WriteLine("Digite o chamado: ");
                string chamado = Console.ReadLine();
                if (ID.Count == 0)
                {
                    ID.Add(1);
                    chamados.Add(chamado);
                } else if (ID.Count != 0)
                {
                    int ultimoID = ID[^1];
                    int nextID = ultimoID + 1;
                    ID.Add(nextID);
                    chamados.Add(chamado);
                }
            } else if (op == 2)
            {
                for (int i = 0; i < ID.Count; i++)
                {
                    Console.WriteLine($"ID: {ID[i]} | Chamado: {chamados[i]}");
                }
            } else if (op == 3)
            {
                Console.WriteLine("Informe o ID do chamado a ser removido: ");
                int id = Convert.ToInt32(Console.ReadLine());
                int indiceASerRemovido = ID.IndexOf(id);
                ID.RemoveAt(indiceASerRemovido);
                chamados.RemoveAt(indiceASerRemovido);
            }
        } while (op != 4);

        
            
    }
}