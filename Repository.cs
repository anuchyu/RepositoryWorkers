using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryWorkers
{
    public class Repository
    {
        public List<Workers> workers = new();

        public void GetAllWorkers()
        {
            foreach (Workers worker in workers)

            {
                Console.WriteLine(worker);
            }            
            // здесь происходит чтение из файла
            // и возврат массива считанных экземпляров
        }

        public void GetWorkerById(int id)
        {
            foreach (Workers worker in workers)
            {
                if (worker.Index == id)
                    Console.WriteLine(worker);
            }
            // происходит чтение из файла, возвращается Worker
            // с запрашиваемым ID
        }

        public void DeleteWorker(int id)
        {
            foreach (Workers worker in workers)
            {
                if (worker.Index == id)
                {
                    workers.Remove(worker);
                    Console.WriteLine("Удаление прошло успешно");
                }
            }
            // считывается файл, находится нужный Worker
            // происходит запись в файл всех Worker,
            // кроме удаляемого
        }

        public void AddWorker()
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите дату рождения число.месяц.год");
            string line = Console.ReadLine();
            DateTime datetime;
            while (!DateTime.TryParseExact(line, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out datetime))
            {
                Console.WriteLine("Неверная дата, попробуйте ещё раз");
                line = Console.ReadLine();
            }

            workers.Add(new Workers(name, datetime));
            Console.WriteLine("Добавление сотрудника прошло успешно");
            // присваиваем worker уникальный ID,
            // дописываем нового worker в файл
        }

        public void GetWorkersBetweenTwoDates()
        {
            Console.WriteLine("Введите дату с которой будем вести отсчет");
            string line = Console.ReadLine();
            DateTime dateFrom;
            while (!DateTime.TryParseExact(line, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dateFrom))
            {
                Console.WriteLine("Неверная дата, попробуйте ещё раз");
                line = Console.ReadLine();
            }
            Console.WriteLine("Введите дату с которой до которой будем вести отсчет");
            line = Console.ReadLine();
            DateTime dateTo;
            while (!DateTime.TryParseExact(line, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dateTo))
            {
                Console.WriteLine("Неверная дата, попробуйте ещё раз");
                line = Console.ReadLine();
            }

            foreach (Workers worker in workers)
            {
                if (worker.BirthDay > dateFrom && worker.BirthDay < dateTo)
                    Console.WriteLine(worker);
            }
            // здесь происходит чтение из файла
            // фильтрация нужных записей
            // и возврат массива считанных экземпляров
        }
    }
}
