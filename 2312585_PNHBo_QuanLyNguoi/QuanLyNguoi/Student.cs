using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNguoi
{
    internal class Student : Person
    {
        public string School {  get; set; }
        public override void Speak()
        {
            Console.WriteLine("I am Studen");
        }

        public void Study()
        {
            Console.WriteLine("Learning.....");
        }

        public Student(string name, int age, string job, string salary, string school) : base (name, age, job, salary)
        {
            this.School = school;
        }

        public Student(string tb):base(tb)
        {
            string[] s = tb.Split(',');
            School = s[4];
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("School : {0}", School);
        }
    }
}
