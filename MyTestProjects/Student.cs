using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProjects
{
    class Student
    {
        public static void Login()
        {
            Console.Write("[ Name ] => ");
            string name = Console.ReadLine();
            Console.Write("[ Surname ] => ");
            string surname = Console.ReadLine();
            Console.Write("[ T.C No ] => ");
            int tcno = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine(" [ ——————————— [ E-okul Account ] ——————————— ]");

            finish();
            void finish()
            {
                Console.WriteLine("[ Name ] => " + name);
                Console.WriteLine("[ Surname ] => " + surname);
                Console.WriteLine("[ T.C No ] => " + tcno);

            }



        }



    }
}
