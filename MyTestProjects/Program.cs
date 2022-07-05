using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProjects
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "E-Okul Login"; 


            Console.WriteLine(" [ ——————————— [ E-okul Login ] ——————————— ] ");


            Student student = new Student();

            Console.Write("[ Name ] => ");
            student.Name = Console.ReadLine();
            Console.Write("[ Surname ] => ");
            student.Surname = Console.ReadLine();
            Console.Write("[ T.C No ] => ");
            student.TCNo = Convert.ToInt32(Console.ReadLine());

            student.Write();







            Console.Read();
        }



    }
}
