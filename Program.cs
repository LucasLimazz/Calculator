﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("Bem-vindo a minha Calculadora! :)");
            Console.WriteLine("Qual operação matemática deseja realizar?");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            switch(res){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Finalizacao(); break;
                default: Menu(); break;
            }
        }

        static void Soma() {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            float resultado =  v1 + v2;
            Console.WriteLine($"O resultado da soma é {resultado}");
            // Segue abaixo outras formas de apresentar este resultado
            // Console.WriteLine("O resultado da soma é " + resultado);
            // Console.WriteLine($"O resultado da soma é {v1 + v2}");
            // Console.WriteLine("O resultado da soma é " + (v1 + v2));
            Console.ReadKey();
            Menu();
        }

        static void Subtracao() {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine()); 

            Console.WriteLine("");

            float resultado = v1 - v2; 
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }
  
        static void Divisao() {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }
   
        static void Multiplicacao(){
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }
    
        static void Finalizacao(){
            Console.Clear();

            Console.WriteLine("Muito obrigado por usar nossa calculadora!!! :D");
            System.Environment.Exit(0);

        }
    }
}


