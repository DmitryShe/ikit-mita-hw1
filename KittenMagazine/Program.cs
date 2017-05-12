using Domain;
using UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KM
{
    class Program
    {
        static void Main(string[] args)
        {

            UI userInterface = new UI();                        // создаем экземпляр класса UI
            userInterface.ShowStartWindow();                    // вызываем метод класса UI для изображаения стартового экрана
            Cat cat = new Cat(userInterface.SetPetAge());       // создаем экземпляр класса Cat(конструктор для инициализации возраста кошки), передаем в него метод класса UI
            userInterface.ShowMenu();                           // вызываем второй метод класса UI для отображаения меню навигации

            int i = 0;                                          // переменная i для управления и навигации по циклу
            while (i != 6 )
            {
                try
                {
                    string str = Console.ReadLine();            // считываем что ввел пользователь
                    i = Convert.ToInt32(str);                   // пытаемся введенное значение перевести в int, если не получается ловим exeption и цикл включается заного, поскольку i !=6
                    switch (i)                                  
                    {                      
                        case 1:
                            if (cat.Name == null)               // по умолчанию при создании экземпляра класса cat.Name == null 
                            {
                                cat.Name = userInterface.SetPetName();
                                Console.WriteLine("Отлично! Что будете делать дальше?");
                                break;
                            }
                            else                                                               
                            Console.WriteLine("Кличка вашего питомца - " + cat.Name);
                            break;
                        case 2:
                            cat.Feed();
                            break;
                        case 3:
                            cat.Punish();
                            break;
                        case 4:
                            Console.WriteLine(cat.Color);
                            break;
                        case 5:
                            userInterface.ShowMenu();
                            break;
                        default:
                            if (i == 6) { break; }              // проверка переменной i, иначе сработает else и у юзера будет надпись "конец" а затем "введите другое значение", а не наооборот
                            else
                                Console.WriteLine("Введите другое значение!");
                                break;
                    }

                }

                catch
                {
                    Console.WriteLine("Неверно введенное значение!");   
                }

                
            }
            Console.WriteLine("Конец");
        }
    }
}
