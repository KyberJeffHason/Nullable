using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<int> foo = null; // Long syntax variant
            int? foo = null; // Short syntax variant

            if (foo.HasValue) // Check if variable has value(not null).
            {
                var sum = 10 + foo;
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Variable value is null");
            }

            DateTime? bar = null; // You can assign nullable to DateTime too!
            bar = DateTime.Now;

            Console.ReadLine();
        }
    }
}
