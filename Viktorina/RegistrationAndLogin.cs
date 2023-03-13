using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viktorina
{
    public class RegistrationAndLogin 
    {
        int limit = 10;
        int limitpass = 8;
        int yearlim1 = 1900;
        int yearlim2 = 2023;
        public string log = "None";
        public string pass = "None";
        int yearofbirthday = 0;
        public void Reg()
        {
            Console.Write($"Введите логин(До {limit} символов):"); 
            log = Console.ReadLine();
            while (log.Length > limit)
            {
                Console.Write($"\nОшибка! Логин должен содержать {limit} символов ! \n Введите логин:");
                log = Console.ReadLine();
            }
            Console.Write("\nЛОГИН СОЗДАН");
            Console.Write($"\nСоздайте пароль:\n- пароль от {limitpass} символов\n- минимум одна заглавная буква:");
            pass = Console.ReadLine();
            while (true)
            {
                int check = 0;
                for (int i = 0; i < pass.Length; i++)
                    if (char.IsUpper(pass[i]))
                    {
                        check = 1;
                    }
                if (pass.Length >= limitpass && check == 1)
                {
                    break;
                }
                Console.Write($"\nОшибка! \nВведите пароль:");
                pass = Console.ReadLine();
            }
            Console.Write("\nПАРОЛЬ СОЗДАН\nВведите год рождения:");
            while (true) {
                yearofbirthday = Convert.ToInt32(Console.ReadLine());
                if (yearofbirthday >= yearlim1 && yearofbirthday <= yearlim2)
                {
                    break;
                }
                Console.Write($"\nОшибка! \nВведите год:");

            };
            Console.Write($"\n Вы зарегистрированы!\nЧтобы продолжить нажмите ENTER:");
            Console.ReadLine();
            Console.Clear();
        }
        public void LoginPerson()
        {
            while (true)
            {
                Console.Write("Введите логин:");
                string checklog = Console.ReadLine();
                Console.Write("\nВведите пароль:");
                string checkpass = Console.ReadLine();
                if (checklog == log && checkpass == pass)
                {
                    Console.Write("\nВы авторизовались!\nЧтобы продолжить нажмите ENTER:");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                Console.Write("\nОшибка! Повторите попытку!");
            }
        }
    }
}
