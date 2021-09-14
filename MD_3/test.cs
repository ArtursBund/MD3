using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD_3
{
    public class test
    {
        public test(string name) : this(name, 10)
        {
            Name = name;
        }
        public test(string name, int age)
        {
            Name = name;
            Age = age;
        }
        private int _age;
        public string Name { get; set; }
        public int Age { 
            get 
            {
                return _age;
            } 
            set
            {
                _age = Math.Abs(value);
            }    
                 
        }
        public bool IsMale { get; set; }
        public decimal Money { get; set; }
        public char Initial { get; set; }

        public string GetGreeting()
        {
            return $"Hello my name is {Name}";
        }
    }
}
