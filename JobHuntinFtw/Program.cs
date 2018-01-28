using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHuntinFtw
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            Functions.AppStart();
            Console.ReadLine();
            Functions.UserStart(user);
            Console.ReadLine();

            Console.Clear();
            Functions.Questions(user);
            Console.ReadKey();


        }
    }
}
