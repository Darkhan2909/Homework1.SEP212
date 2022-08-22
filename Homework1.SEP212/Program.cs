using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.SEP212
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи: ");

            int example = Convert.ToInt32(Console.ReadLine());

            if(example == 1)
            {
                FirstExample();
            }
            else if(example == 2)
            {
                SecondExample();
            }
            else
            {
                Console.WriteLine("Такой задачи нет!");
            }
           
        }

        //Задание номер 1
        private static void FirstExample()
        {
            Console.WriteLine("Введите Ваше имя: ");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Введите Вашу фамилию: ");
            string LastName = Console.ReadLine();

            Console.WriteLine("Введите Ваше отчество: ");
            string SecondName = Console.ReadLine();

            Console.WriteLine("Приветствую тебя " + FirstName + " " + LastName + " " + SecondName + "!");
        }

        //Задание номер 2
        private static void SecondExample()
        {
            Console.WriteLine("Введите первое число: ");
            string number1 = Console.ReadLine();

            Console.WriteLine("Введите второе число: ");
            string number2 = Console.ReadLine();

            Console.WriteLine("Сумма, Ваших чисел равна: ");
            int result = Convert.ToInt32(number1) + Convert.ToInt32(number2);

            Console.WriteLine(result);
        }
    }
}
