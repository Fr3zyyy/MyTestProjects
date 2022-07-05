using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProjects
{
    class Student
    {

        public string Name;
        public string Surname;
        public int TCNo;


        public void Write()
        {
            Console.Title = "E-Okul Account";
            Console.Clear();
            Console.WriteLine(" [ ——————————— [ E-Okul Account ] ——————————— ] ");
            Console.WriteLine("[ Name ] => " + Name);
            Console.WriteLine("[ Surname ] => " + Surname);
            Console.WriteLine("[ T.C No ] => " + TCNo);
        }

    }
}
