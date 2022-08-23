using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryWorkers
{
    public class RepositoryWorkers
    {
        public List<Worker> workers = new();

        public void GetAllWorkers()
        {
            ReadingWorker();
        }

        public void GetWorkerById(int id)
        {
            GetWorkerId(id);
        }

        public void DeleteWorkerById(int id)
        {
            DeleteWorker(id);
        }

        public void AddWorker()
        {
            CreateWorker();
        }

        public void GetWorkersBetweenTwoDates()
        {
            TwoDate();
        }

        public void CreateWorker()
        {
            // присваиваем worker уникальный ID,
            // дописываем нового worker в файл

            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите дату рождения число.месяц.год");
            string date = Console.ReadLine();
            DateTime dateFromBorn;
            while (!DateTime.TryParseExact(date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dateFromBorn))
            {
                Console.WriteLine("Неверная дата, попробуйте ещё раз");
                date = Console.ReadLine();
            }

            workers.Add(new Worker(name, dateFromBorn));
            Console.WriteLine($"Добавление сотрудника с id = {workers.Count} прошло успешно");
        }

        public void DeleteWorker(int id)
        {
            // считывается файл, находится нужный Worker
            // происходит запись в файл всех Worker,
            // кроме удаляемого

            foreach (Worker worker in workers)
            {
                if (worker.Count == id)
                {
                    workers.Remove(worker);
                    Console.WriteLine("Удаление прошло успешно");
                }
            }
        }

        public void GetWorkerId (int id)
        {
            // происходит чтение из файла, возвращается Worker
            // с запрашиваемым ID

            foreach (Worker worker in workers)
            {
                if (worker.Count == id)
                    Console.WriteLine(worker);
            }
        }

        public void ReadingWorker()
        {
            // здесь происходит чтение из файла
            // и возврат массива считанных экземпляров

            foreach (Worker worker in workers)

            {
                Console.WriteLine(worker);
            }
        }

        public void TwoDate()
        {
            // здесь происходит чтение из файла
            // фильтрация нужных записей
            // и возврат массива считанных экземпляров

            Console.WriteLine("Введите дату с которой будем вести отсчет");
            string date = Console.ReadLine();
            DateTime dateFrom;
            while (!DateTime.TryParseExact(date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dateFrom))
            {
                Console.WriteLine("Неверная дата, попробуйте ещё раз");
                date = Console.ReadLine();
            }
            Console.WriteLine("Введите дату с которой до которой будем вести отсчет");
            date = Console.ReadLine();
            DateTime dateTo;
            while (!DateTime.TryParseExact(date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dateTo))
            {
                Console.WriteLine("Неверная дата, попробуйте ещё раз");
                date = Console.ReadLine();
            }

            if (dateFrom < dateTo) foreach (Worker worker in workers)
            {
                if (worker.BirthDay > dateFrom && worker.BirthDay < dateTo)
                {
                    Console.WriteLine(worker);
                }
            }
        }
    }
}
