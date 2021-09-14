using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD_3
{
    // Uzd 4
    public class Person
    {
        public Person(string name, string surname, string birthdate, string hobby, string gender)
            {
            Name = name;
            Surname = surname;
            BirthDate = birthdate;
            Hobby = hobby;
            Gender = gender;
            Greeting(BirthDate);
            }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
        public string Hobby { get; set; }
        public string Gender { get; set; }
                
        public void Greeting(string input)
        {
            string[] DateInput = input.Split('.');
            string[] DateToday = DateTime.Today.ToString("d").Split('.');
            double Age=new double();
            double Age_y = Convert.ToDouble(DateToday[2]) - Convert.ToDouble(DateInput[2]);
            double Age_m = Convert.ToDouble(DateToday[1]) - Convert.ToDouble(DateInput[1]);
            double Age_d = Convert.ToDouble(DateToday[0]) - Convert.ToDouble(DateInput[0]);

            if (Age_m>=0)
            {
                if (Age_d>0)
                {
                    Age = Age_y;
                }
                else
                {
                    Age = Age_y - 1;
                }
            }
            else
            {
                Age = Age_y - 1;
            }

            Console.WriteLine("Hello my name is {0} {1} an I am {2}", Name, Surname, Age);
        }
    }
}
