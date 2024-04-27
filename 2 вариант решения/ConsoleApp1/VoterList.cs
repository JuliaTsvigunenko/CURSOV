using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Класс, в котором хранятся все методы
    class VoterList
    {
        /// <summary>
        /// Приватное поле используется для хранения списка избирателей
        /// </summary>
        private List<Voter> voters = new List<Voter>();

        /// <summary>
        /// Метод для вывода информации о всех избирателях в списке на консоль
        /// </summary>
        public void ShowInfo()
        {
            Load();
            foreach (var voter in voters)
            {
                Console.WriteLine(voter);
            }
        }

        /// <summary>
        /// 3 Добавление человека в начало списка
        /// </summary>
        public void AddStart()
        {
            Load();
            voters.Insert(0, Init());
            Save();
        }

        /// <summary>
        /// 4 Добавление человека в конец списка
        /// </summary>
        public void AddEnd()
        {
            Load();
            voters.Add(Init());
            Save();
        }

        /// <summary>
        /// 5 Метод для добавления человека после определенного человека
        /// </summary>
        public void AddAfter()
        {
            Load();
            Console.WriteLine("Введите индекс изберателя, после которого вы хотите добавить нового: ");
            int index = int.Parse(Console.ReadLine());
            voters.Insert(index+1, Init());
            Save();
        }

        /// <summary>
        /// 6 Метод для добавления человека перед определенным человеком
        /// </summary>
        public void AddBefore()
        {
            Load();
            Console.WriteLine("Введите индекс изберателя, перед которым вы хотите добавить нового: ");
            int index = int.Parse(Console.ReadLine());
            voters.Insert(index, Init());
            Save();
        }

        /// <summary>
        /// 7 Метод для удаления избирателя из списка 
        /// </summary>
        public void RemoveVoter()
        {
            Load();
            Console.WriteLine("Введите индекс избирателя которого надо удалить ");
            int index = int.Parse(Console.ReadLine());
            voters.Remove(voters[index]);
            Save();
        }

        /// <summary>
        /// Метод для создания экземпляров класса
        /// </summary>
        /// <returns></returns>
        public Voter Init()
        {
            Console.WriteLine("Введите полное ФИО избирателя: ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Введите адрес избирателя: ");
            string address = Console.ReadLine();
            Console.WriteLine("Введите возраст избирателя: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер участка избирателя: ");
            int plotNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год голосованя избирателя: ");
            int yearOfVoting=int.Parse(Console.ReadLine());
            Console.WriteLine("Голосование 1-Да; 2-Нет; 3-Воздерживаюсь");
            int vote = int.Parse(Console.ReadLine());
            return new Voter(fullName,address,age,plotNumber,yearOfVoting,vote);
        }
       
     
   
        /// <summary>
        /// 8 Метод для вывода избирателей по возрастным группам
        /// </summary>
        public void PrintByAgeGroup()
        {
            Load();
            Console.WriteLine("Младше 30 лет:");
            foreach (var voter in voters)
            {
                if (voter.Vote == 1&&voter.Age<30)
                {
                    Console.WriteLine($"{voter}");
                }
            }
            Console.WriteLine("От 30 лет до 50:");
            foreach (var voter in voters)
            {
                if (voter.Vote == 1)
                {
                    if (voter.Age >= 30&&voter.Age <= 50)
                    {
                        Console.WriteLine($"{voter}");
                    }
                    
                }
            }
            Console.WriteLine("Старше 50 лет:");
            foreach (var voter in voters)
            {
                if (voter.Vote == 1 && voter.Age > 50)
                {
                    Console.WriteLine($"{voter}");
                }
            }
            Save();
        }

        /// <summary>
        /// 9 По запросу выдаются сведения о избирателях, ответивших отрицательнго или воздержусь в текущем году 
        /// </summary>
        public void PrintVozd()
        {
            Load();
            foreach(var voter in voters)
            {
                if(voter.Vote == 2 || voter.Vote == 3)
                {
                    Console.WriteLine(voter.ToString());
                }
            }
            Save();
        }

        /// <summary>
        /// 10 По запросу создается второй односвязный список, содержащий только информацию о избирателях определенного участка
        /// </summary>
        public void ListPlotNumber()
        {
            Load();
            bool tr = false; //переменная для проверки существования участка
            Console.WriteLine("Введите номер учатска: ");
            int number = int.Parse(Console.ReadLine());
            foreach (var voter in voters)
            {
                List<Voter> voters1= new List<Voter>();//создание коллекции
                
                if (voter.PlotNumber == number)
                {
                    voters1.Add(voter);
                    tr = true;
                }
                foreach(var v in voters1)
                {
                    Console.WriteLine(v.ToString());
                }
            }
            if (tr == false)
            {
                Console.WriteLine("Такого участка не существует, попробуйте еще раз");
            }
            Save();
        }

        /// <summary>
        /// Путь к файлу
        /// </summary>
        string path = @"C:\Users\Kab-35-6\Desktop\2 вариант решения\ConsoleApp1\Voters.bin";

        /// <summary>
        /// Метод для сохранения в файл
        /// </summary>
        public  void Save()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, voters);
            }
        }

        /// <summary>
        /// Метод для загрузки из файлов
        /// </summary>
        public  void Load()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                voters = (List<Voter>)formatter.Deserialize(fs);
            }
        }



    }
}
