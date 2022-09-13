using System;

class Program
{
    private static void Main(string[] args)
    {
        Boolean cont = false;

        do{
        Console.WriteLine("CALCULADORA");
        float valor1, valor2;

        Console.WriteLine("Informe o valor 1: ");
        valor1 = float.Parse(Console.ReadLine());

        Console.WriteLine("\nInforme a opção desejada, ou 0(zero) para sair:");
        Console.WriteLine("+ (somar)\n- (subtrair)\n/ (dividir)\n* (multiplicar)\n");
        string op = Console.ReadLine();

        if(op == "0"){
            Console.WriteLine("Operação finalizada.");
            cont = true;
            break;
        }

        Console.WriteLine("Informe o valor 2: ");
        valor2 = float.Parse(Console.ReadLine());

        Console.Clear();

        switch (op)
        {
            case "+":
                somar(valor1, valor2);
                break;
            case "-":
                subtrair(valor1, valor2);
                break;
            case "/":
                dividir(valor1, valor2);
                break;
            case "*":
                multiplicar(valor1, valor2);
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
        Console.WriteLine("\n");
        }while (cont != true);
        
        static void somar(float a, float b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        static void subtrair(float a, float b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
        static void dividir(float a, float b)
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
        static void multiplicar(float a, float b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }
    }
}