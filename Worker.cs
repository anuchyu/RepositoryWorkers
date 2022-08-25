using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryWorkers
{
    public class Worker
    {
        private static int counter;
        private string name;
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
                {
                    birthDay = value;
                }
            }
        }
        public int ID { get; private set; }
        public Worker (string name, DateTime birthDay)
        {
            ID = ++counter;
            Name = name;
            BirthDay = birthDay;
        }

        public override string ToString()
        {
            return $"Id: {ID} Name:{name} Birthday:{birthDay.ToShortTimeString} Age:{DateTime.Now.Year - birthDay.Year} DateCreate:{timeCreated}";
        }
    }
}
