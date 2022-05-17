using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps_Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Users user = new Users("Suresh Desari", 30);
            user.GetUserDetails();
            Console.ReadLine();
        }
    }
}
