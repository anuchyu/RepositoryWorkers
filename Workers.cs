using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryWorkers
{
    public class Workers
    {

        private int index = 0;
        private int age;
        private string name = "";
        private DateTime dateTime;
        private DateTime birthDay; 

        public string Name { get { return name; } set { name = value; } }  
        public DateTime DateTime { get { return dateTime; } set { dateTime = DateTime.Now; } }
        public DateTime BirthDay
        {
            get 
            { 
                return dateTime; 
            }
            set 
            {
                if (value < new DateTime(2010) && value > new DateTime(1930))
                birthDay = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {

                age = (dateTime.Year - birthDay.Year);
            }
        }
        public int Index
        {
            get { return index; }   
            set { index++; }
        }

        public Workers (string name, DateTime birthDay)
        {
            Index = index;
            Age = age;
            Name = name;
            BirthDay = birthDay;
            DateTime = dateTime;
        }
    }
}
