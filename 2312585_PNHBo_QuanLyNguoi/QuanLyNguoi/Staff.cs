using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNguoi
{
    internal class Staff : Person
    {

        public string Jobtitle { get; set; }
        public string WorkingTime {  get; set; }

        public Staff(string name, int age, string job, string salary,string jobtitle, string workingTime):base(name, age, job ,salary)
        {
            Jobtitle = jobtitle;
            WorkingTime = workingTime;
        }

        public override void Speak()
        {
            Console.WriteLine("I am staff.");
        }


        public Staff() { }
        public Staff(string tb) :base(tb)
        {
            String[] s = tb.Split(',');
            Jobtitle = s[4];
            WorkingTime = s[5];
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Job Titile : {0}\nWorking Time : {1}\n",Jobtitle,WorkingTime);
        }
    }

}
