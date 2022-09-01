namespace RepositoryWorkers
{
    public static class Repository_Workers
    {
        public static List<Worker> workers = new();

        public static void ShowAllWorkers()
        {
            workers.ForEach(worker => Console.WriteLine(worker));
        }

        public static void GetWorkerById(int id)
        {
            var worker = workers.FirstOrDefault(w => w.Id == id);
            Console.WriteLine(worker);
        }

        public static void DeleteWorkerById(int id)
        {
            var worker = workers.FirstOrDefault(w => w.Id == id);
            workers.Remove(worker);
            Console.WriteLine("Удаление прошло успешно");
        }

        public static void AddWorker(string name, DateTime dateFromBorn)
        {
            workers.Add(new Worker(name, dateFromBorn));
            Console.WriteLine($"Добавление сотрудника с id = {workers.Count} прошло успешно");
        }

        public static void GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {

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
