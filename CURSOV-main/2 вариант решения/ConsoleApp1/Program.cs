using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            VoterList voterList = new VoterList(); // Создание экземпляра списка избирателей

            while (true) // Основной цикл программы для работы с меню
            {
                Console.WriteLine("Меню программы по работе с избирателями");
                Console.WriteLine("1. Вывести всех избирателей");
                Console.WriteLine("2. Добавить избирателя в начало списка");
                Console.WriteLine("3. Добавить избирателя в конец списка");
                Console.WriteLine("4. Добавить избирателя после указанного избирателя");
                Console.WriteLine("5. Добавить избирателя перед указанным избирателем");
                Console.WriteLine("6. Удалить избирателя из списка");
                Console.WriteLine("7. Вывести избирателей по возрастным группам");
                Console.WriteLine("8. Вывести избирателей с негативным или воздержательным голосом в текущем году");
                Console.WriteLine("9. Создать новый список избирателей по номеру участка");
                Console.WriteLine("10. Выход из программы");
                Console.WriteLine();
                Console.Write("Введите номер действия: ");

                int izbiratel = int.Parse(Console.ReadLine());
                switch (izbiratel)
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine("Вывод информации о всех избирателях");
                        voterList.ShowInfo();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Добавть избирателя в начало списка");
                        voterList.AddStart();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Добавить избирателя в конец списка");
                        voterList.AddEnd();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Добавить избирателя после указанного избирателя");
                        voterList.AddAfter();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Добавить избирателя перед указанным избирателем");
                        voterList.AddBefore();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Удалить избирателя из списка");
                        voterList.RemoveVoter();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Вывести избирателей по возрастным группам");
                        voterList.PrintByAgeGroup();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Вывести избирателей с негативным или воздержательным голосом в текущем году");
                        voterList.PrintVozd();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Создать новый список избирателей по номеру участка");
                        voterList.ListPlotNumber();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 0:
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Неверный номер, повторите еще раз.");
                        break;

                }

                Console.ReadLine();

            }
            
        }
    }
}
