using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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
            foreach (var voter in voters)
            {
                Console.WriteLine(voter);
            }
        }
        /// <summary>
        /// 3
        /// </summary>
        public void AddStart()
        {
            voters.Insert(0, Init());
        }
        /// <summary>
        /// 4
        /// </summary>
        public void AddEnd()
        {
            voters.Add(Init());
        }
        /// <summary>
        /// 5
        /// </summary>
        public void AddAfter()
        {
            Console.WriteLine("Введите индекс изберателя  посое которого вы хотите добавить нового");
            int index = int.Parse(Console.ReadLine());
            voters.Insert(index+1, Init());
        }
        /// <summary>
        /// 6
        /// </summary>
        public void AddBefore()
        {
            Console.WriteLine("Введите индекс изберателя перед которым вы хотите добавить нового");
            int index = int.Parse(Console.ReadLine());
            voters.Insert(index, Init());
        }

        /// <summary>
        /// Метод для удаления избирателя из списка 7
        /// </summary>

        public void RemoveVoter()
        {
            Voter voter1 = null;
            foreach (var voter in voters)
            {
                Console.WriteLine(voter.ToString());
                Console.WriteLine("Введите индекс избирателя которого надо удалить ");
                int index = int.Parse(Console.ReadLine());
                voter1 = voters[index];
            }
            voters.Remove(voter1);
        }

        public Voter Init()
        {
            Console.WriteLine("Введите полное имя");
            string fullName = Console.ReadLine();
            Console.WriteLine();
            string address = Console.ReadLine();
            Console.WriteLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int plotNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int yearOfVoting=int.Parse(Console.ReadLine());
            Console.WriteLine("1-да 2 нет 3 воздерживаюсь");
            int vote = int.Parse(Console.ReadLine());
            return new Voter(fullName,address,age,plotNumber,yearOfVoting,vote);
        }
       
     
       

       

      


        /// <summary>
        /// Метод для вывода избирателей по возрастным группам
        /// </summary>
        /// <param name="minAge"></param>
        /// <param name="maxAge"></param>
        public void PrintByAgeGroup()
        {
            foreach (var voter in voters)
            {
                if (voter.Vote == 1)
                {
                    if (voter.Age < 30 )
                    {
                        Console.WriteLine($"Младше 30 лет: {voter}");
                    }
                    else if (voter.Age >= 30 && voter.Age <= 50)
                    {
                        Console.WriteLine($"От 30 до 50 лет: {voter}");
                    }
                    else if (voter.Age > 50 )
                    {
                        Console.WriteLine($"Старше 50 лет: {voter}");
                    }
                }
            }
        }
        /// <summary>
        /// 9
        /// </summary>
        public void PrintVozd()
        {
            foreach(var voter in voters)
            {
                if(voter.Vote == 2 || voter.Vote == 3)
                {
                    Console.WriteLine(voter.ToString());
                }
            }
        }
        /// <summary>
        /// 10
        /// </summary>
        public void ListPlotNumber()
        {
            foreach(var voter in voters)
            {
                List<Voter> voters1= new List<Voter>();
                Console.WriteLine("введите номер учатска");
                int number=int.Parse(Console.ReadLine());
                if (voter.PlotNumber == number)
                {
                    voters1.Add(voter);
                }
            }
        }





    }
}
