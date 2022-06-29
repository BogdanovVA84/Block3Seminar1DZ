// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N. (не включая N)
// 5 -> 2, 4
// 8 -> 2, 4, 6


namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {      
            int a = 1;
                        
            Console.WriteLine("Введите число N: ");             
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Четные числа: ");
            for (int i = a; i<N; i++)
            {
                if (i % 2 == 0)            
                {
                    Console.WriteLine(i + "");
                }      
                          
            }
            Console.ReadKey();
        }        
    }            
}
