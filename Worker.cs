namespace RepositoryWorkers
{
    public class Worker
    {
        private static int counter;
        private DateTime birthDay; 

        public string Name { get; set; }  
        public DateTime TimeCreated { get; } = DateTime.Now;
        public DateTime BirthDay
        {
            get 
            { 
                return birthDay; 
            }
            set 
            {
                if (value.Year < 2010 && value.Year > 1930)
                {
                    birthDay = value;
                }
            }
        }
        public int Id { get; }
        public Worker (string name, DateTime birthDay)
        {
            Id = ++counter;
            Name = name;
            BirthDay = birthDay;
        }

        public override string ToString()
        {
            return $"Id: {Id} Name:{Name} Birthday:{BirthDay} Age:{DateTime.Now.Year - birthDay.Year} " +
                $"DateCreate:{TimeCreated}";
        }
    }
}
