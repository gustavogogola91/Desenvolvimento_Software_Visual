namespace Exercicios_1;

#pragma warning disable CS8604, CS8600, CS8602

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
            Console.Write("Digite o número de um exercicio(0 para sair): ");
            int op = Int32.Parse(Console.ReadLine());

            switch (op)
            {
                case 0:
                    continuar = false;
                    break;

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
                    Ex05();
                    break;
                case 6:
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
                case 11:
                    Ex11();
                    break;
                case 12:
                    Ex12();
                    break;
                case 13:
                    try
                    {
                        Ex13();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    break;
                case 14:
                    Ex14();
                    break;
                case 15:
                    Ex15();
                    break;
                case 16:
                    Ex16();
                    break;
                case 17:
                    Ex17();
                    break;
                case 18:
                    Ex18();
                    break;
                case 19:
                    Ex19();
                    break;
                case 20:
                    Ex20();
                    break;
                default:
                    break;
            }
        }
    }

    static void Ex01()
    {

        Console.Write("Digite um número: ");
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

        Console.Write("Digite um número: ");
        int num1 = Int32.Parse(Console.ReadLine());
        Console.Write("Digite outro número: ");
        int num2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine($"Soma: {num1 + num2}");
    }

    static void Ex03()
    {

        Console.Write("Digite um número: ");
        int A = Int32.Parse(Console.ReadLine());

        Console.Write("Digite outro número: ");
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

        Console.Write("Digite um número: ");
        int num1 = Int32.Parse(Console.ReadLine());

        Console.Write("Digite outro número: ");
        int num2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine($"Soma: {num1 + num2}");
        Console.WriteLine($"Subtração: {num1 - num2}");
        Console.WriteLine($"Multiplicação: {num1 * num2}");
        Console.WriteLine($"Divisão: {num1 / num2}");
    }

    static void Ex05()
    {

        Console.Write("Digite um número: ");
        int num1 = Int32.Parse(Console.ReadLine());

        Console.Write("Digite outro número: ");
        int num2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine($"Antes da troca: A={num1} B={num2}");

        int aux = num1;
        num1 = num2;
        num2 = aux;

        Console.WriteLine($"Depois da troca: A={num1} B={num2}");
    }

    static void Ex06()
    {

        Console.Write("Digite uma temperatura e Celsius: ");
        int tempCels = Int32.Parse(Console.ReadLine());

        int tempFah = ((9 * tempCels) / 5) + 32;

        Console.WriteLine($"Conversão para Fahrenheit: {tempFah}");
    }

    static void Ex07()
    {

        Console.Write("Digite um número: ");
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
        Console.Write("Digite um número: ");
        int num = Int32.Parse(Console.ReadLine());

        if (num >= 50)
        {
            Console.WriteLine("O numero é maior ou igual à 50");
        }
        else
        {
            Console.WriteLine("O numero é menor que 50");
        }
    }

    static void Ex09()
    {
        Console.Write("Digite um número: ");
        int A = Int32.Parse(Console.ReadLine());

        Console.Write("Digite um número: ");
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
            Console.Write("Digite um número de 1 a 5: ");
            num = Int32.Parse(Console.ReadLine());

            switch (num)
            {
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

    static void Ex11()
    {

        Console.Write("Digite um número: ");
        int num1 = Int32.Parse(Console.ReadLine());
        Console.Write("Digite outro número: ");
        int num2 = Int32.Parse(Console.ReadLine());
        Console.Write("Digite mais um número: ");
        int num3 = Int32.Parse(Console.ReadLine());

        int[] list = new int[3];
        list[0] = num1;
        list[1] = num2;
        list[2] = num3;

        for (int j = 0; j < list.Length; j++)
        {
            for (int i = 0; i < list.Length - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    int aux = list[i];
                    list[i] = list[i + 1];
                    list[i + 1] = aux;
                }
            }
        }

        Console.Write("Números em ordem crescente: ");
        foreach (int item in list)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    static void Ex12()
    {

        int num;

        while (true)
        {
            Console.Write("Digite um número de um mês: ");
            num = Int32.Parse(Console.ReadLine());

            if (num > 0 && num < 13)
            {
                break;
            }

            Console.WriteLine("Mês inválido, digite novamente.");
        }

        switch (num)
        {
            case 1:
                Console.WriteLine("Janeiro");
                break;
            case 2:
                Console.WriteLine("Fevereiro");
                break;
            case 3:
                Console.WriteLine("Março");
                break;
            case 4:
                Console.WriteLine("Abril");
                break;
            case 5:
                Console.WriteLine("Maio");
                break;
            case 6:
                Console.WriteLine("Junho");
                break;
            case 7:
                Console.WriteLine("Julho");
                break;
            case 8:
                Console.WriteLine("Agosto");
                break;
            case 9:
                Console.WriteLine("Setembro");
                break;
            case 10:
                Console.WriteLine("Outubro");
                break;
            case 11:
                Console.WriteLine("Novembro");
                break;
            case 12:
                Console.WriteLine("Dezembro");
                break;
        }

    }

    static void Ex13()
    {

        string op;

        Console.Write("Digite um número: ");
        double num1 = Double.Parse(Console.ReadLine());
        while (true)
        {
            Console.Write("Digite a operação (+, -, * ou /): ");
            op = Console.ReadLine();

            if (op.Equals("+") || op.Equals("-") || op.Equals("*") || op.Equals("/"))
            {
                break;
            }

            Console.WriteLine("Operador inválido");
        }

        Console.Write("Digite outro número: ");
        double num2 = Double.Parse(Console.ReadLine());

        if (op.Equals("+"))
        {
            Console.WriteLine($"Soma: {num1} + {num2} = {num1 + num2}");
        }
        else if (op.Equals("-"))
        {
            Console.WriteLine($"Subtração: {num1} - {num2} = {num1 - num2}");
        }
        else if (op.Equals("*"))
        {
            Console.WriteLine($"Multiplicação: {num1} * {num2} = {num1 * num2}");
        }
        else if (op.Equals("/"))
        {
            if (num2 == 0)
            {
                throw new Exception("Não é possível fazer divisão por zero!");
            }
            else
            {
                Console.WriteLine($"Divisão: {num1} / {num2} = {num1 / num2}");
            }
        }



    }

    static void Ex14()
    {
        Console.Write("Digite o primeiro termo da PA: ");
        int a1 = Int32.Parse(Console.ReadLine());

        Console.Write("Digite a posição do número a ser descoberto: ");
        int pos = Int32.Parse(Console.ReadLine());

        Console.Write("Digite a rezão: ");
        int r = Int32.Parse(Console.ReadLine());

        int an = a1 + ((pos - 1) * r);

        Console.WriteLine($"O valor na posição {pos} da PA é {an}");
    }

    static void Ex15()
    {
        Console.Write("Digite a cordenada x do ponto 1: ");
        int p1x = Int32.Parse(Console.ReadLine());


        Console.Write("Digite a cordenada y do ponto 1: ");
        int p1y = Int32.Parse(Console.ReadLine());


        Console.Write("Digite a cordenada x do ponto 2: ");
        int p2x = Int32.Parse(Console.ReadLine());


        Console.Write("Digite a cordenada y do ponto 2: ");
        int p2y = Int32.Parse(Console.ReadLine());

        double distance = Math.Round(Math.Sqrt((Math.Pow((p2x - p1x), 2)) + Math.Pow((p2y - p1y), 2)), 2);

        Console.WriteLine($"Distância entre os pontos 1 e 2 é igual a {distance}");
    }

    static void Ex16()
    {
        Console.Write("Digite a nota 1: ");
        double nota1 = Double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        double nota2 = Double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        double nota3 = Double.Parse(Console.ReadLine());

        double soma = ((nota1 + nota2 + nota3) / 3);
        double media = Math.Round(soma, 2);

        Console.WriteLine($"Resultado: {media}");
    }

    static void Ex17()
    {

        Console.Write("Digite a nota 1: ");
        double nota1 = Double.Parse(Console.ReadLine());

        Console.Write("Digite o peso da nota 1: ");
        double peso1 = Double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        double nota2 = Double.Parse(Console.ReadLine());

        Console.Write("Digite o peso da nota 2: ");
        double peso2 = Double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        double nota3 = Double.Parse(Console.ReadLine());

        Console.Write("Digite o peso da nota 3: ");
        double peso3 = Double.Parse(Console.ReadLine());


        double media = Math.Round((((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3)) / (peso1 + peso2 + peso3)), 2);

        Console.WriteLine($"Média: {media}");

    }

    static void Ex18()
    {

        Console.Write("Digite a nota 1: ");
        double nota1 = Double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        double nota2 = Double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        double nota3 = Double.Parse(Console.ReadLine());

        double mediaH = Math.Round((3 / ((1 / nota1) + (1 / nota2) + (1 / nota3))), 2);

        Console.WriteLine($"Média harmônica: {mediaH}");

    }

    static void Ex19()
    {

        Console.Write("Informe o raio: ");
        double r = Double.Parse(Console.ReadLine());

        Console.Write("Informe a altura: ");
        double alt = Double.Parse(Console.ReadLine());

        double vol = Math.Round((Math.PI * Math.Pow(r, 2) * alt), 2);

        Console.WriteLine($"Volume do cilindro: {vol}");

    }

    static void Ex20()
    {

        Console.Write("Informe o tempo da viagem(em horas): ");
        double tempo = Double.Parse(Console.ReadLine());

        Console.Write("informe a velocidade média(em KM/h): ");
        double vel = Double.Parse(Console.ReadLine());

        double combustivel = Math.Round(((tempo * vel) / 12), 2);

        Console.WriteLine($"Combustível gasto: {combustivel} litros");

    }

}
