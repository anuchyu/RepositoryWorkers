using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryWorkers
{
    public class Worker
    {
        private int count;
        private int age;
        private string name = "";
        private DateTime birthDay; 

        public string Name { get; set; }  
        public DateTime timeCreated { get; } = DateTime.Now;
        public DateTime BirthDay
        {
            get 
            { 
                return birthDay; 
            }
            set 
            {
                if (value.Year < 2010 && value.Year > 1930)
                birthDay = value;
            }
        }
        public int Age { get; }
        public int Count { get; }
        public Worker (int count, string name, DateTime birthDay)
        {
            this.count = count++;
            if (BirthDay.Month >= timeCreated.Month)
            {
                age = timeCreated.Year - BirthDay.Year;
            }
            else
            {
                age = timeCreated.Year - BirthDay.Year-1; 
            }

            Name = name;
            BirthDay = birthDay;
        }

        public override string ToString()
        {
            return $"Id: {count} Name:{name} Birthday:{birthDay} Age:{age} DateCreate:{timeCreated}";
        }
    }
}
