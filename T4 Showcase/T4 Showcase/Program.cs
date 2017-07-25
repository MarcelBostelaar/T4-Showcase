using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_Showcase
{
    class Program
    {
        static void Main(string[] args)
        {
            //See ExampleTemplate.tt
            TupleOf5<int, int, int, int, int> example = new TupleOf5<int, int, int, int, int>(1, 2, 3, 4, 5);
        }
    }
}
