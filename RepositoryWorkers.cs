namespace RepositoryWorkers
{
    public class RepositoryWorkers
    {
        public List<Worker> workers = new();

        public void ShowAllWorkers()
        {
            workers.ForEach(worker => Console.WriteLine(worker));
        }

        public void GetWorkerById(int id)
        {
            var worker = workers[id];
            Console.WriteLine(worker);
        }

        public void DeleteWorkerById(int id)
        {
            var worker = workers[id];
            workers.Remove(worker);
            Console.WriteLine("Удаление прошло успешно");
        }

        public void AddWorker(string name, DateTime dateFromBorn)
        {
            workers.Add(new Worker(name, dateFromBorn));
            Console.WriteLine($"Добавление сотрудника с id = {workers.Count} прошло успешно");
        }

        public void GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
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
