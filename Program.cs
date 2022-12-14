using System.Globalization;
using RepositoryWorkers;

do
    {
        Console.WriteLine("Что будем делать? Введите цифру на экран\n1.Выведем на экран\n2.Выведем на экран сотрудника по ID\n" +
            "3.Удалим сотрудника\n4.Добавим нового сотрудника\n5.Выведем список сотрудников между определенными датами рождения");
        string number = Console.ReadLine();

        switch (number)
        {
            case "1":
            Repository_Workers.ShowAllWorkers();
                break;

            case "2":
            Repository_Workers.GetWorkerById(WorkerId());
                break;

            case "3":
            Repository_Workers.DeleteWorkerById(WorkerId());
                break;

            case "4":
            var newWorker = NewWorker();
            Repository_Workers.AddWorker(newWorker.name, newWorker.dateFromBorn);
                break;

            case "5":
            var dateFromDateTo = DateFromDateTo();
            Repository_Workers.GetWorkersBetweenTwoDates(dateFromDateTo.dateFrom, dateFromDateTo.dateTo);
                break;

            default:
                Console.WriteLine("Такой цифры нет");
                break;
        }

    } while (Console.ReadKey().Key != ConsoleKey.Escape);

int WorkerId()
    {
        int id;
        Console.WriteLine("Введите ID?");
        string checkId = Console.ReadLine();
        while (!int.TryParse(checkId, out id))
        {
            Console.WriteLine("неверное число");
            checkId = Console.ReadLine();
        }
    return id;
    }
(string name, DateTime dateFromBorn) NewWorker ()
    {
        Console.WriteLine("Введите имя работника");
        string name= Console.ReadLine();
        Console.WriteLine("Введите дату рождения работника");
        string  date= Console.ReadLine();
        DateTime dateFromBorn;
        while (!DateTime.TryParseExact(date, "dd/MM/yyyy", null, DateTimeStyles.None, out dateFromBorn))
        {
            Console.WriteLine("Неверная дата, попробуйте ещё раз");
            date = Console.ReadLine();
        }
        return (name,dateFromBorn);
    }
(DateTime dateFrom, DateTime dateTo) DateFromDateTo()
    {
        Console.WriteLine("Введите дату с которой будем вести отсчет");
        string date = Console.ReadLine();
        DateTime dateFrom;
        while (!DateTime.TryParseExact(date, "dd/MM/yyyy", null, DateTimeStyles.None, out dateFrom))
        {
            Console.WriteLine("Неверная дата, попробуйте ещё раз");
            date = Console.ReadLine();
        }
        Console.WriteLine("Введите дату с которой до которой будем вести отсчет");
        date = Console.ReadLine();
        DateTime dateTo;
        while (!DateTime.TryParseExact(date, "dd/MM/yyyy", null, DateTimeStyles.None, out dateTo))
        {
            Console.WriteLine("Неверная дата, попробуйте ещё раз");
            date = Console.ReadLine();
        }
        return (dateFrom, dateTo);
    }


