using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viktorina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в приложение Викторина!");

            RegistrationAndLogin obj1 = new RegistrationAndLogin();
            
            /*while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Войти");
                Console.WriteLine("2 - Зарегистрироваться");
                Console.WriteLine("3 - Выход");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    obj1.LoginPerson();
                }
                else if (choice == 2)
                {
                    obj1.Reg();
                    obj1.LoginPerson();
                    break;
                }
                else if (choice == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка: неправильный выбор.");
                }
            }
*/
            while (true)
            {
                Console.WriteLine("Выберите викторину:");
                Console.WriteLine("1 - История");
                Console.WriteLine("2 - География");
                Console.WriteLine("3 - Биология");
                Console.WriteLine("4 - Смешанная");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        QuizHistory obj2 = new QuizHistory();
                        obj2.RunH();
                        break;
                    case 2:
                        QuizGeography obj3 = new QuizGeography();
                        obj3.RunG();
                        break;
                    case 3:
                        QuizBiology obj4 = new QuizBiology();
                        obj4.RunB();
                        break;
                    case 4:
                        
                        break;
                    default:
                        Console.WriteLine("Ошибка: неправильный выбор.");
                        return;
                }

            }
            Console.ReadLine();
        }

    }
}
    

