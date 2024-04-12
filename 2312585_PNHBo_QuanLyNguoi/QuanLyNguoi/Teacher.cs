using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNguoi
{
    internal class Teacher : Person
    {
        public Teacher( string name, int age, string job, string salary, string subject) :base (name, age, job, salary)
        {
            Subject = subject;
        }

        public string Subject { get; set; }

        public override void Speak()
        {
            Console.WriteLine("I am Teacher");
        }

        public void Teach()
        {
            Console.WriteLine("Teaching.....");
        }

        public Teacher(string tb):base(tb)
        {
            string[] s = tb.Split(',');
            Subject = s[4];
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Subject : {0}", Subject);
        }
    }
}
