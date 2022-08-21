using RepositoryWorkers;

Repository repository = new ();
do
    {
        Console.WriteLine("Что будем делать? Введите цифру на экран\n1.Выведем на экран\n2.Выведем на экран сотрудника по ID\n" +
            "3.Удалим сотрудника\n4.Добавим нового сотрудника\n5.Выведем список сотрудников между определенными датами рождения");
        int number = Convert.ToInt32(Console.ReadLine());

        switch (number)
        {
            case 1:
            repository.GetAllWorkers();
                break;

            case 2:
            int id;
            Console.WriteLine("Какое ID смотрим?");
            string line = Console.ReadLine();
            while (int.TryParse(line, out id))
            {
                Console.WriteLine("неверное число");
                line = Console.ReadLine();
            }
            repository.GetWorkerById(id);
                break;

            case 3:
            int idDelete;
            Console.WriteLine("Какое ID удаляем?");
            line = Console.ReadLine();
            while (int.TryParse(line, out idDelete))
            {
                Console.WriteLine("неверное число");
                line = Console.ReadLine();
            }
            repository.DeleteWorker(idDelete);
                break;

            case 4:
            repository.AddWorker();
                break;
            case 5:
            repository.GetWorkersBetweenTwoDates();
                break;
            default:
                Console.WriteLine("Такой цифры нет");
                break;
        }


    } while (true);

