using System;

namespace Patinhos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Digite quantos patinhos: ");
            int patinho=Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            
            for (i = patinho; i >1 ; i=i-1)
            {
               Console.WriteLine($"\n{i} patinhos foram passear\nAlém das montanhas, para brincar\nA mamãe gritou: Quá, quá, quá, quá\nMas só " +(i-1)+ " patinhos voltaram de lá."); 
            }
            Console.WriteLine($"\n{i} patinho foi passear\nAlém das montanhas, para brincar\nA mamãe gritou: Quá, quá, quá, quá\nMas nenhum patinho voltou de lá.");
            Console.WriteLine($"\nA mamãe patinha foi procurar\nAlém das montanhas, na beira do mar\nA mamãe gritou: Quá, quá, quá, quá\nE os {patinho} patinhos voltaram de lá.");
        }
    }
}
