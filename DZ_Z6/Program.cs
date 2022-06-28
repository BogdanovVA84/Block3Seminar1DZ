// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,  
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {      
            Console.WriteLine("Введите число: ");
            int a;
                                    
            a = int.Parse(Console.ReadLine());
            
            if (a % 2 == 0)            
            {
                Console.WriteLine("число четное");
            }      
            else
            {
                Console.WriteLine("число нечетное");
            }                

        }        
    }            
}


