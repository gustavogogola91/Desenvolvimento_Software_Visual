namespace Exercicios_1;

class Program
{
    static void Main(string[] args)
    {
        ex02();
    }

    static void ex01() {

        Console.WriteLine("Digite um número ");
        int num = Int32.Parse(Console.ReadLine());

        if(num > 10) {
            Console.WriteLine("Número maior do que 10!");
        } else {
            Console.WriteLine("Número menor ou igual a 10!");
        }

    }

    static void ex02() {

        Console.WriteLine("Digite um número.");
        int num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número.");
        int num2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine($"Soma: {num1 + num2}");
    }

    static void ex03() {

        Console.WriteLine("Digite um número: ");
        int A = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite outro número: ");
        int B = Int32.Parse(Console.ReadLine());

        if(A == B) {
            Console.WriteLine("Os números são iguais!");
        } else if(A > B) {
            Console.WriteLine($"O maior número é {A}");
        } else {
            Console.WriteLine($"O maior número é {B}");
        }
    }
}
