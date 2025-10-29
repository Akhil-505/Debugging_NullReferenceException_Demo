using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging_NullReferenceException_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> students = null;
            List<string> students = new List<string>();
            students.Add("Suraj");

        }
    }
}
