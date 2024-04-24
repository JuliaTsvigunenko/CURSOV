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

            //while (true) // Основной цикл программы для работы с меню
            //{
                Console.WriteLine("Меню программы по работе с избирателями");
                Console.WriteLine("1. Вывести всех избирателей");
                Console.WriteLine("2. Добавить избирателя в начало списка");
                Console.WriteLine("3. Добавить избирателя в конец списка");
                Console.WriteLine("4. Добавить избирателя после указанного избирателя");
                Console.WriteLine("5. Добавить избирателя перед указанным избирателем");
                Console.WriteLine("6. Удалить избирателя из списка");
                Console.WriteLine("7. Вывести избирателей по возрастным группам");
                Console.WriteLine("8. Вывести избирателей с негативным голосом в текущем году");
                Console.WriteLine("9. Создать новый список избирателей по номеру участка");
                Console.WriteLine("10. Сохранить данные в бинарный файл");
                Console.WriteLine("11. Загрузить данные из бинарного файла");
                Console.WriteLine("12. Выход из программы");
                Console.Write("Введите номер действия: ");
                
            Console.ReadLine();

            //}
        }
    }
}
