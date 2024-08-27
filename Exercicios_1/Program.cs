using System.Globalization;

namespace Exercicios_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escreva um exercicio");
        int op = Int32.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                Ex01();
                break;
            case 2:
                Ex02();
                break;
            case 3:
                Ex03();
                break;
            case 4:
                Ex04();
                break;
            case 5:
                Ex06();
                break;
            case 7:
                Ex07();
                break;
            case 8:
                Ex08();
                break;
            case 9:
                Ex09();
                break;
            case 10:
                Ex10();
                break;
            // case 11:
            //     Ex11();
            //     break;
            // case 12:
            //     Ex12();
            //     break;
            // case 13:
            //     Ex13();
            //     break;
            // case 14:
            //     Ex14();
            //     break;
            // case 15:
            //     Ex15();
            //     break;
            // case 16:
            //     Ex16();
            //     break;
            // case 17:
            //     Ex17();
            //     break;
            // case 18:
            //     Ex18();
            //     break;
            // case 19:
            //     Ex19();
            //     break;
            // case 20:
            //     Ex20();
            //     break;
            default:
                break;
        }
    }

    static void Ex01()
    {

        Console.WriteLine("Digite um número ");
        int num = Int32.Parse(Console.ReadLine());

        if (num > 10)
        {
            Console.WriteLine("Número maior do que 10!");
        }
        else
        {
            Console.WriteLine("Número menor ou igual a 10!");
        }

    }

    static void Ex02()
    {

        Console.WriteLine("Digite um número.");
        int num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número.");
        int num2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine($"Soma: {num1 + num2}");
    }

    static void Ex03()
    {

        Console.WriteLine("Digite um número: ");
        int A = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro número: ");
        int B = Int32.Parse(Console.ReadLine());

        if (A == B)
        {
            Console.WriteLine("Os números são iguais!");
        }
        else if (A > B)
        {
            Console.WriteLine($"O maior número é {A}");
        }
        else
        {
            Console.WriteLine($"O maior número é {B}");
        }
    }

    static void Ex04()
    {

        Console.WriteLine("Digite um número:");
        int num1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro número:");
        int num2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine($"Soma: {num1 + num2}");
        Console.WriteLine($"Subtração: {num1 - num2}");
        Console.WriteLine($"Multiplicação: {num1 * num2}");
        Console.WriteLine($"Divisão: {num1 / num2}");
    }

    static void Ex05()
    {

        Console.WriteLine("Digite um número:");
        int num1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro número:");
        int num2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine($"Antes da troca: A={num1} B={num2}");

        int aux = num1;
        num1 = num2;
        num2 = aux;

        Console.WriteLine($"Depois da troca: A={num1} B={num2}");
    }

    static void Ex06()
    {

        Console.WriteLine("Digite uma temperatura e Celsius:");
        int tempCels = Int32.Parse(Console.ReadLine());

        int tempFah = ((9 * tempCels) / 5) + 32;

        Console.WriteLine($"Conversão para Fahrenheit: {tempFah}");
    }

    static void Ex07()
    {

        Console.WriteLine("Digite um número:");
        int num = Int32.Parse(Console.ReadLine());

        if (num > 100 && num < 200)
        {
            Console.WriteLine("O número está no intervalo 100 - 200");
        }
        else
        {
            Console.WriteLine("O número não está no intervalo 100 - 200");
        }
    }

    static void Ex08()
    {
        Console.WriteLine("Digite um número:");
        int num = Int32.Parse(Console.ReadLine());

        if (num >= 50)
        {
            Console.WriteLine("O numero u maior que 50");
        }
        else
        {
            Console.WriteLine("O numero e menor que 50");
        }
    }

    static void Ex09()
    {
        Console.WriteLine("Digite um número:");
        int A = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite um número:");
        int B = Int32.Parse(Console.ReadLine());

        if (A == B)
        {
            Console.WriteLine("Os números são iguais");
        }
        else
        {
            Console.WriteLine("Os números são diferentes");

            if (A > B)
            {
                Console.WriteLine($"O número {A} é maior");
            }
            else
            {
                Console.WriteLine($"O número {B} é maior");
            }
        }
    }

    static void Ex10()
    {

        int num = 0;

        while (num < 1 || num > 5)
        {
            Console.WriteLine("Digite um número de 1 a 5:");
            num = Int32.Parse(Console.ReadLine());

            switch(num) {
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
                case 4:
                    Console.WriteLine("Quatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
                default:
                    Console.WriteLine("O número deve estar entre 1 e 5");
                    break;
            }
        }
    }

    static void Ex11() {

    }

}
