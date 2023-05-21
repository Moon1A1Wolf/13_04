using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate void MenuDelegate();

    internal class Program
    {
        static void Main(string[] args)
        {
            MenuDelegate menuDelegate = new MenuDelegate(ShowMenu);
            menuDelegate += NewGame;
            menuDelegate += LoadGame;
            menuDelegate += ShowRules;
            menuDelegate += ShowAuthor;

            while (true)
            {
                ShowMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice >= 0 && choice <= 4)
                {
                    menuDelegate.GetInvocationList()[choice]();
                    if (choice == 0)
                        break;
                }
                else
                {
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1 - Новая игра");
            Console.WriteLine("2 - Загрузить игру");
            Console.WriteLine("3 - Правила");
            Console.WriteLine("4 - Об авторе");
            Console.WriteLine("0 - Выход");
        }

        static void NewGame()
        {
            Console.WriteLine("Вы выбрали 'Новая игра'");
        }

        static void LoadGame()
        {
            Console.WriteLine("Вы выбрали 'Загрузить игру'");
        }

        static void ShowRules()
        {
            Console.WriteLine("Вы выбрали 'Правила'");
        }

        static void ShowAuthor()
        {
            Console.WriteLine("Вы выбрали 'Об авторе'");
        }
    }
}
