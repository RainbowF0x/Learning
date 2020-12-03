using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Repository
    {

        static readonly string[] firstNames; 
        static readonly string[] lastNames;
        static Random randomize;

        static Repository()
        {
            randomize = new Random();

            firstNames = new string[] 
            {
                "Агата",
                "Агнес",
                "Аделаида",
                "Аделина",
                "Алдона",
                "Алима",
                "Аманда",
            };

            lastNames = new string[]
            {
                "Иванова",
                "Петрова",
                "Васильева",
                "Кузнецова",
                "Ковалёва",
                "Попова",
                "Пономарёва",
                "Дьячкова",
                "Коновалова",
                "Соколова",
                "Лебедева",
                "Соловьёва",
                "Козлова",
                "Волкова",
                "Зайцева",
                "Ершова",
                "Карпова",
                "Щукина",
                "Виноградова",
                "Цветкова",
                "Калинина"
            };
        }
        public List<Worker> Workers { get; set; }
                                                  
        public Repository(int Count)
        {
            this.Workers = new List<Worker>();

            for (int i = 0; i < Count; i++)
            {

                this.Workers.Add(
                    new Worker(

                        firstNames[Repository.randomize.Next(Repository.firstNames.Length)],
                        lastNames[Repository.randomize.Next(Repository.lastNames.Length)],
                        randomize.Next(19, 60),
                        randomize.Next(10000, 80000)
                        ));
            }
        }




        public void Print(string Text)
        {
            Console.WriteLine(Text);
            Console.WriteLine($"{"Имя",15} {"Фармилия",15} {"Возрас",10} {"Зарплата",15}");

            foreach (var worker in this.Workers) 
                Console.WriteLine(worker);

            Console.WriteLine($"Итого: {this.Workers.Count}\n");
        }


        public void DeleteWorkerBySalary(int MaxSalary)
        {
            this.Workers.RemoveAll(e => e.Salary > MaxSalary);
        }
        public void DeleteWorkerByName(string CurrentName)
        {
            this.Workers.RemoveAll(e => e.FirstName == CurrentName);
        }


    }
}
