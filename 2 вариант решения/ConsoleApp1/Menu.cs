using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Класс меню
    class Menu
    {
        public static void Menu1()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            VoterList voterList = new VoterList(); // Создание экземпляра списка избирателей

            while (true) // Основной цикл программы для работы с меню
            {
                Console.Clear();
                //1 Вывод меню для работы со списком
                Console.WriteLine("Меню программы по работе с избирателями");
                Console.WriteLine("------------");
                Console.WriteLine("1. Вывести всех избирателей");
                Console.WriteLine("2. Добавить избирателя в начало списка");
                Console.WriteLine("3. Добавить избирателя в конец списка");
                Console.WriteLine("4. Добавить избирателя после указанного избирателя");
                Console.WriteLine("5. Добавить избирателя перед указанным избирателем");
                Console.WriteLine("6. Удалить избирателя из списка");
                Console.WriteLine("7. Вывести избирателей по возрастным группам ответивших положительно");
                Console.WriteLine("8. Вывести избирателей с негативным или воздержательным голосом в текущем году");
                Console.WriteLine("9. Вывести список избирателей по номеру участка");
                Console.WriteLine("10. Выход из программы");
                Console.WriteLine("------------");
                Console.Write("Введите номер действия: ");

                int izbiratel = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (izbiratel)
                {
                    //2 вывод всех людей case 1
                    case 1:

                        Console.WriteLine("Вывод информации о всех избирателях");
                        voterList.ShowInfo();


                        break;
                    case 2:

                        Console.WriteLine("Добавть избирателя в начало списка");
                        voterList.AddStart();


                        break;
                    case 3:

                        Console.WriteLine("Добавить избирателя в конец списка");
                        voterList.AddEnd();


                        break;
                    case 4:

                        Console.WriteLine("Добавить избирателя после указанного избирателя");
                        voterList.AddAfter();


                        break;
                    case 5:

                        Console.WriteLine("Добавить избирателя перед указанным избирателем");
                        voterList.AddBefore();


                        break;
                    case 6:

                        Console.WriteLine("Удалить избирателя из списка");
                        voterList.RemoveVoter();


                        break;
                    case 7:

                        Console.WriteLine("Вывести избирателей по возрастным группам");
                        voterList.PrintByAgeGroup();


                        break;
                    case 8:

                        Console.WriteLine("Вывести избирателей с негативным или воздержательным голосом в текущем году");
                        voterList.PrintVozd();


                        break;
                    case 9:

                        Console.WriteLine("Создать новый список избирателей по номеру участка");
                        voterList.ListPlotNumber();


                        break;
                    case 0:
                        return;
                    default:

                        Console.WriteLine("Выход из программы.");
                        break;

                }

                Console.ReadLine();

            }
        }
    }
}
