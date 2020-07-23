 using System;
using System.Collections.Generic;


class Program
{
    public static List<int> Numeros = new List<int>{};
    static void Main()
    {
        Console.Clear();

        Console.WriteLine("====================================================");
        Console.WriteLine("       Selecione uma Opção para continuar:          ");
        Console.WriteLine("                                                    ");
        Console.WriteLine("       1 - Add novo numero                          ");
        Console.WriteLine("       2 - Remover o numero                         ");
        Console.WriteLine("       3 - Buscar um numero                         ");
        Console.WriteLine("       4 - Numeros pares                            ");
        Console.WriteLine("       5 - Numeros impares                          ");
        Console.WriteLine("       6 - Sair do sistema                          ");
        Console.WriteLine("                                                    ");
        Console.WriteLine("====================================================");
        
        Console.Write("Selecione uma das opções acima: ");
        if (int.TryParse(Console.ReadLine(), out int Variable)){
            switch (Variable)
            {
                case 1:
                    Console.Clear();

                    Console.Write("Digite um numero para adicionar: ");

                    if (int.TryParse(Console.ReadLine(), out int OutedNumber)){
                        Numeros.Add(OutedNumber);
                        Console.WriteLine("Numero adicionado com sucesso.");

                        Print();

                        Console.WriteLine("Pressiona qualquer tecla para sair.");
                        Console.ReadKey();
                        Main();
                    } else 
                        Main();
                    break;

                case 2:
                    Console.Clear();
                    
                    Console.Write("Digite um numero para remover: ");

                    if (int.TryParse(Console.ReadLine(), out OutedNumber)){
                        if (Numeros.Contains(OutedNumber))
                            Numeros.Remove(OutedNumber);

                        Console.WriteLine("Numero removido com sucesso.");

                        Print();

                        Console.WriteLine("Pressiona qualquer tecla para sair.");
                        Console.ReadKey();
                        Main();
                    } else 
                        Main();
                    break;

                case 3:
                    Console.Clear();

                    Console.Write("Digite um numero para buscar: ");

                    if (int.TryParse(Console.ReadLine(), out OutedNumber)){
                        Print(OutedNumber);

                        Console.WriteLine("Pressiona qualquer tecla para sair.");
                        Console.ReadKey();
                        Main();
                    } else 
                        Main();
                    break;

                case 4:
                    Console.Clear();

                    Console.WriteLine("Imprimindo Numeros Pares");

                    Print(-2);

                    Console.WriteLine("Pressiona qualquer tecla para sair.");
                    Console.ReadKey();
                    Main();
                    break;

                case 5:
                    Console.Clear();

                    Console.WriteLine("Imprimindo Numeros Impares");

                    Print(-3);

                    Console.WriteLine("Pressiona qualquer tecla para sair.");
                    Console.ReadKey();
                    Main();
                    break;

                case 6:
                    Console.Clear();

                    Console.WriteLine("Saindo..");

                    System.Environment.Exit(1);
                    break;
                
                default:
                    Main();
                    break;
            }
        }
    }

    static void Print(int rrt=-1) {
        Console.WriteLine("\nLista de numeros Abaixo :");

        Action PrintBuscando = () => {
            foreach (var item in Numeros)
            {
                if (rrt == item)
                    Console.WriteLine("{0} *", item);
                else
                    Console.WriteLine("{0}", item);
            }
        };
        Action Print = () => {
            foreach (var item in Numeros)
                Console.WriteLine("{0}", item);
        };
        Action PrintPar = () => {
            foreach (var item in Numeros) {
                if ((item % 2) == 0)
                    Console.WriteLine("{0}", item);
            }
        };
        Action PrintImpar = () => {
            foreach (var item in Numeros) {
                if ((item % 2) == 1)
                    Console.WriteLine("{0}", item);
            }
        };

        if (rrt == -2)
            PrintPar();
        else if (rrt == -3)
            PrintImpar();
        else if (rrt != -1)
            PrintBuscando();
        else
            Print();

        Console.WriteLine("");
    }
}
