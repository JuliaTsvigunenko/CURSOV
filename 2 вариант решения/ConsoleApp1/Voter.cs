using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Класс Избиратель
    class Voter
    {

        /// <summary>
        /// ФИО избирателя
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Адрес проживания
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Номер участка
        /// </summary>
        public int PlotNumber { get; set; }

        /// <summary>
        /// Год голосования
        /// </summary>
        public int YearOfVoting { get; set; }

        /// <summary>
        /// Голосование (да / нет/ воздерживаюсь)
        /// </summary>
        public int Vote { get; set; }

        public Voter() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="address"></param>
        /// <param name="age"></param>
        /// <param name="plotNumber"></param>
        /// <param name="yearOfVoting"></param>
        /// <param name="vote"></param>


        public Voter(string fullName, string address, int age, int plotNumber, int yearOfVoting, int vote)
        {
           FullName = fullName;
           Address = address;
           Age = age;
           PlotNumber = plotNumber;
           YearOfVoting = yearOfVoting;
           Vote = vote;
         }


         /// <summary>
         /// Метод для вывода информации об избирателях
         /// </summary>
         /// <returns></returns>
         public override string ToString()
         {
            return $"ФИО: {FullName}\nАдресс: {Address}\nВозраст: {Age}\nНомер участка: {PlotNumber}\nГод голосования: {YearOfVoting}\nГолос: {Vote}";
         }
        
        


    }
}
