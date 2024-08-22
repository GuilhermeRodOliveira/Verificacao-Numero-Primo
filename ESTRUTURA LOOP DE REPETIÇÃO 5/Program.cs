using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;
        //5 - Faça um programa que peça ao usuário para inserir um número e, em seguida, imprima se esse número é primo ou não usando um loop for.

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro:");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool primo = IsPrime(numero);

        if (primo)
            Console.WriteLine($"{numero} é um número primo.");
        else
            Console.WriteLine($"{numero} não é um número primo.");
    }

}
