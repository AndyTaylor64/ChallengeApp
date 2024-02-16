using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    class Employee
    {

        private List<int> score = new();

        public Employee(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return score.Sum();
            }
        }

        public void AddScore(int number)
        {
            score.Add(number);
        }
    }
}
