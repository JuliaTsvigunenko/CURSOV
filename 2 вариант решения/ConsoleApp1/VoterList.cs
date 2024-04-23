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
        /// Метод для добавления нового избирателя в список
        /// </summary>
        /// <param name="voter"></param>
        public void AddVoter(Voter voter)
        {
            voters.Add(voter);
        }

        /// <summary>
        /// Метод для удаления избирателя из списка
        /// </summary>
        /// <param name="voter"></param>
        public void RemoveVoter(Voter voter)
        {
            voters.Remove(voter);
        }

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
        /// Метод для вывода избирателей по возрастным группам
        /// </summary>
        /// <param name="minAge"></param>
        /// <param name="maxAge"></param>
        public void PrintByAgeGroup(int minAge, int maxAge)
        {
            foreach (var voter in voters)
            {
                if (voter.Age < 30 && voter.Age >= minAge)
                {
                    Console.WriteLine($"Младше 30 лет: {voter}");
                }
                else if (voter.Age >= 30 && voter.Age <= 50)
                {
                    Console.WriteLine($"От 30 до 50 лет: {voter}");
                }
                else if (voter.Age > 50 && voter.Age <= maxAge)
                {
                    Console.WriteLine($"Старше 50 лет: {voter}");
                }
            }
        }




    }
}
