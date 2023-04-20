using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class TestClass : Ix, Iy, Iz
    {
        public double val;

        public double IxF0(double key)
        {
            val = key;
            return Math.Log(val);
        }

        public double IxF1()
        {
            return Math.Log(val);
        }

        public double F0(double key)
        {
            val = key;
            return 2 / val;
        }

        public double F1()
        {
            return 2 / val;
        }

        double Iz.F0(double key)
        {
            val = key;
            return Math.Pow(val, 3); ;

        }

        double Iz.F1()
        {
            return Math.Pow(val, 3);
        }
    }
}

namespace task1
{
    interface Ix
    {
        double IxF0(double key);
        double IxF1();
    }

    interface Iy
    {
        double F0(double key);
        double F1();
    }
    interface Iz
    {
        double F0(double key);
        double F1();
    }
}
namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass ts = new TestClass();

            Console.WriteLine($"IxF0: {ts.IxF0(10):f2}, IxF1: {ts.IxF1():f2}");
            Console.WriteLine($"F0: {ts.F0(10)}, F1: {ts.F1()}");
            Console.WriteLine($"F0: {((Iz)ts).F0(10)}, F1: {((Iz)ts).F1()}");


        }
    }
}