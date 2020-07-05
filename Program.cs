using System;

namespace auladepc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos patinhos: ");
            int patinho=Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            
            for (int i = patinho; i >1 ; i=i-1)
            {
               Console.WriteLine(i + " patinhos foram passear, além das montanhas, para brincar, a mamãe gritou: Quá, quá, quá, quá, mas só " +(i-1)+ " patinhos voltaram de lá."); 
            }
            Console.WriteLine("1 patinho foi passear, além das montanhas, para brincar, a mamãe gritou: Quá, quá, quá, quá, mas nenhum patinho voltou de lá.");
            Console.WriteLine("A mamãe patinha foi procurar, além das montanhas, na beira do mar, a mamãe gritou: Quá, quá, quá, quá, e os " +patinho+ " patinhos voltaram de lá.");
        }
    }
}