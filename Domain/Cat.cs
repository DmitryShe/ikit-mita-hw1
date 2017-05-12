using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Здравствуйте, Денис!
 * Здравствуйте, Сергей!
 * 
 * Спасибо за работу!
*/

namespace Domain
{
    public class Cat
    {
        private int health = 5;
        private string name;

        public Cat(int age)
        {
            Age = age;
        }

        public int Age { get; }

        public string Name { get { return name; } set { name = value; } }      
        
        public string Color
        {
            get
            {
                if      (health  < 5)   return "Red";
                else if (health == 5)   return "Yellow";
                else if (health  > 5)   return "Green";
                else                    return "Bleached";
            }
            set { }          
        }

        public void Feed()
        {
           // можно отключить комментарии чтобы посмотреть что переменные не пустые, если не хочется через f11, f10
             /*
            Console.WriteLine(name);
            Console.WriteLine(Age);
            Console.WriteLine(Color);
            Console.WriteLine(health);
            */
            Console.WriteLine("Кошка мурлычет, муррррр...");
            if (health >= 10) { health = 10; }
            else
                health++;
        }

        public void Punish()
        {
            Console.WriteLine("Вы замахиваетесь на кошку, она ловко уворачивается от удара. Во взгляде у неё виден укор");
            if (health <= 1) { health = 1; }
            else
                health--;
        }
    }
}
