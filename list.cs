using System;
using System.Collections.Generic;

var nome = ("Heitor");

List<string> tarefas = new List<string>();

while (true){

    Console.WriteLine("\nLISTA DE TAREFAS");
    Console.WriteLine("1 - Adicionar Tarefa");
    Console.WriteLine("2 - Ver Tarefa");
    Console.WriteLine("3 - Remover Tarefa");
    Console.WriteLine("4 - Sair");

    string opcao = Console.ReadLine();

    if (opcao == "1")
    {
        Console.WriteLine("Digite a Tarefa");
        string Tarefa = Console.ReadLine();

        tarefas.Add(Tarefa);
    }
    else if (opcao == "2")
    {
        Console.WriteLine("Olá " + nome + (" Suas Tarefas Hoje São: "));

        for (int i = 0; i < tarefas.Count; i++)
        {
            Console.WriteLine(i + " - " + tarefas[i]);
        }
    }
    else if(opcao == "3")
    {
        Console.WriteLine("Olá " + nome + " Digite a tarefa que deseja remover:");
        int indice = Convert.ToInt32(Console.ReadLine());

        tarefas.RemoveAt(indice);
    }
    else if (opcao == "4")
    {
        break;
    }

}