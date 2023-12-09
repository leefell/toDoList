using System;
using System.Collections.Generic;

// Last update: 09/12/2023

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de Listagem de Tarefas");
            List<string> listaTarefas = new List<string>();
            string opcao = "";

            while (opcao != "0")
            {
                ExibirMenu();
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarTarefa(listaTarefas);
                        break;
                    case "2":
                        RemoverTarefa(listaTarefas);
                        break;
                    case "3":
                        ListarTarefas(listaTarefas);
                        break;
                    case "0":
                        Console.WriteLine("\nSaindo.");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }

            Console.WriteLine("Obrigado por usar o programa.");
        }

        static void ExibirMenu()
        {
            Console.WriteLine("\n========== MENU ==========");
            Console.WriteLine("1 - Adicionar Tarefa");
            Console.WriteLine("2 - Remover Tarefa");
            Console.WriteLine("3 - Lista Tarefas");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("===========================");
            Console.Write("Escolha uma opção: ");
        }

        static void AdicionarTarefa(List<string> listaTarefas)
        {
            Console.WriteLine("\nDigite a tarefa para adicionar à lista: ");
            string tarefa = Console.ReadLine();
            listaTarefas.Add(tarefa);
            Console.WriteLine("Tarefa adicionada com sucesso.\n");
            Console.Clear();
        }

        static void RemoverTarefa(List<string> listaTarefas)
        {
            if (listaTarefas.Count == 0)
            {
                Console.WriteLine("Não existem tarefas registradas");
            }
            else
            {
                Console.Clear();
                for (int i = 0; i < listaTarefas.Count; i++)
                {
                    Console.WriteLine(i + ": " + listaTarefas[i]);
                }

                Console.Write("\nDigite o número da tarefa para remover da lista: ");
                if (int.TryParse(Console.ReadLine(), out int numeroTarefa) && numeroTarefa >= 0 && numeroTarefa < listaTarefas.Count)
                {
                    listaTarefas.RemoveAt(numeroTarefa);
                    Console.Clear();
                    Console.WriteLine("\nTarefa removida.");
                }
                else
                {
                    Console.WriteLine("\nOpção inválida. Digite um número válido.");
                }
            }
        }

        static void ListarTarefas(List<string> listaTarefas)
        {
            if (listaTarefas.Count == 0)
            {
                Console.WriteLine("Não existem tarefas adicionadas.");
            }
            else
            {
                Console.WriteLine("\n--- Tarefas Adicionadas ---");
                foreach (string task in listaTarefas)
                {
                    Console.WriteLine(task);
                }
            }
        }
    }
}
