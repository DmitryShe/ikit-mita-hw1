using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public class UI
    {
        public void ShowStartWindow()
        {
            Console.WriteLine("Здравствуйте! Благодарим Вас за приобритение нашего продукта!\nКошка для программиста Version < 2.0 >");
            Console.WriteLine("\nПеред первым запуском необходимо ввести возраст питомца!");
        }

        public void ShowMenu()
        {
            Console.WriteLine("\nМеню (Напишите номер требуемого пункта меню в командной строке и нажмите клавишу Enter)");
            Console.WriteLine(
                "\n1 - Дать\\Посмотреть кличку питомца" +
                "\n2 - Погладить" +
                "\n3 - Наказать" +
                "\n4 - Посмотреть окрас" +
                "\n5 - Показать меню\n" +
                "\n6 - Выход из программы\n");
        }

        public int SetPetAge()
        {
            int i;
            while (true)
            {
                try
                {
                    Console.WriteLine("\nПожалуйста, введите возраст Вашего питомца (возраст питомца должен быть в пределах от 1 до 19 лет): ");
                    i = Convert.ToInt32(Console.ReadLine());

                    if (i >= 1 && i <= 19)
                    {
                        Console.WriteLine("\nВозраст питомца активирован. Равен {0} ", i);
                        break;
                    }
                    else if (i > 19)
                    {
                        Console.WriteLine("Таких старых кошек у нас нет :)");                      
                    }
                    else if (i < 1)
                    {
                        Console.WriteLine("Таких в продаже нет :)");                       
                    }
                }

                catch 
                {
                    Console.WriteLine("\nВведенное значение не верно! Введите другое!");                    
                }
            }
            return i;
        }
          

        public string SetPetName()
        {
            Console.WriteLine("\nПожалуйста, введите имя Вашего питомца: ");
            string str = Console.ReadLine();
            return str;
        }
    }
}
