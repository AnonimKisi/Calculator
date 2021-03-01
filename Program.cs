//Made by AnonimKisi
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Made by AnonimKisi";
            int i = 0;
            Console.Write("How many numbers are you going to enter?: ");
            int number_of_numbers = Convert.ToInt32(Console.ReadLine());
            double[] numbers = { };
            Array.Resize(ref numbers, number_of_numbers);
            Console.WriteLine();
            while (i < number_of_numbers)
            {                
                Console.Write((i + 1) + ". number: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
                i++;
            }
            i = 0;
            double sum = 0;
            double sub = numbers[i];
            double div = numbers[i];
            double multi = numbers[i];
            while (i < number_of_numbers)
            {
                sum = sum + numbers[i];
                i++;
            }
            i = 0;
            while(i < (number_of_numbers-1))
            {
                i++;
                sub = sub - numbers[i];
            }
            i = 0;
            while (i < (number_of_numbers - 1))
            {
                i++;
                div = div / numbers[i];
            }
            i = 0;
            while (i < (number_of_numbers - 1))
            {
                i++;
                multi = multi * numbers[i];
            }
            Console.WriteLine("\n--------------");
            Console.WriteLine("+: {0}", sum);
            Console.WriteLine("-: {0}", sub);
            Console.WriteLine("/: {0}", div);
            Console.WriteLine("x: {0}", multi);
            Console.WriteLine("--------------\n");
            Main();
        }
    }
}