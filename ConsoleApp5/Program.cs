using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    static class Program
    {

        static void Main(string[] args)
        {


            int First = 1, Second = 2, Third = 3;

            Console.WriteLine($"Выберите что Вы хотите: \n{First} - Вывод Базы \n{Second} - Редактирование Базы \n{Third} - Внесение Новых Сотрудников"); //через конкатинацию вывожу на консоль варианты выбора


            string text = Console.ReadLine();                                                   //Ввожу стринговую переменную которая является тем что введут в консоли с клавиатуры 
            int Input = Convert.ToInt32(text);                                                  //Ввожу переменную "ввод с клавиатуры" которая является переменной текст конвертированной в инт для последующего использования
            switch (Input)                                                                      //Ввожу оператор выбора в зависмимости от того что выбрал пользователь
            {
                case 1:
                    Console.WriteLine("Вы выбрали вывод базы");                                 
                    Repository repository = new Repository(30);                                 //вопрос, а как вместо 30 сделать i-тое значене которое будет подставлятьсяв скобки из Console.Readline()
                    repository.Print("");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали редактирование базы");
                    //repository.DeleteWorkerByName("Агата");                                   //Но почему то когда я вствляю это часть, выдает ошибку ((
                    //repository.Print("База данных после первого преобразования");
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали внесение нового сотрудника");

                    break;
                default:
                    Console.WriteLine("Вы выбрали не допустимое значение");

                    break;
            }
            Console.ReadKey();



















        }

    }
}
