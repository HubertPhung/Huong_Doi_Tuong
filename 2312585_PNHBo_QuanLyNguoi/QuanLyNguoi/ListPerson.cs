using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNguoi
{
    internal class ListPerson
    {
        List<Person> ds = new List<Person>();

        public void Them(Person n)
        {
            ds.Add(n);
        }

        public void DocFile(string tenfile)
        {
            StreamReader streamReader = new StreamReader(tenfile);
            string s = "";

            while ((s = streamReader.ReadLine()) != null) 
            {
                if (s.Contains("Teacher"))
                {
                    Person teacher = new Teacher(s);
                    ds.Add(teacher);
                }
                else if (s.Contains("Studen"))
                {
                    Person student = new Student(s);
                    ds.Add(student);
                }
                else
                {
                    Person staff = new Staff(s);
                    ds.Add(staff);
                }
                
            }
        }

        public void Xuat()
        {
            foreach (Person n in ds)
            {
                Console.WriteLine(n);
                Console.WriteLine();
            }
        }
    }
}
