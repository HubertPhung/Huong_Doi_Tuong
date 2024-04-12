using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNguoi
{
    internal class Person
    {
       

        public string Name { get; set; }
        public int Age { get; set; }
        public string Job {  get; set; }
        public string Salary {  get; set; }
        

        public virtual void Speak()
        {
            Console.WriteLine("I am human ! ");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Eating......");
        }

        public Person(string name, int age, string job, string salary)
        {
            Name = name;
            Age = age;
            Job = job;
            Salary = salary;
        }

        public Person()
        { 

        }

        public Person(string tb) 
        {
            String[] s = tb.Split(',');
            Name = s[0];
            Age = int.Parse(s[1]);
            Job = s[2];
            Salary = s[3];
        }

        public override string ToString()
        {
            return string.Format("Name : {0}\nAge : {1}\nJob : {2}\nSalary : {3}\n", Name, Age, Job, Salary);
        }

    }
}
