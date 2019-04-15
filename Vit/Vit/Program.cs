using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vit
{
    class Program
    {
        static AutoResetEvent Handl = new AutoResetEvent(false);
        public static void Th1()
        {
            Console.WriteLine("1 thread");



        }
        public static void Th2()
        {
            Console.WriteLine("2 thread");


        }
        public static void Th3()
        {
            Console.WriteLine("3 thread");
            Handl.Set();

        }
        public static void Th4()
        {

            Console.WriteLine("4 thread");
            Handl.Set();

        }
        public static void Th5()
        {
            Console.WriteLine("5 thread");
            Handl.Set();


        }
        public static void Th6()
        {
            Console.WriteLine("6 thread");
            Handl.Set();

        }
        public static void Th7()
        {
            Console.WriteLine("7 thread");
            Handl.Set();

        }
        public static void Th8()
        {
            Console.WriteLine("8 thread");
            Handl.Set();
        }
        public static void Th9()
        {
            Console.WriteLine("9 thread");
            Handl.Set();
        }

        static void Main(string[] args)
        {
            
            Thread t1 = new Thread(() => Th1());
            Thread t2 = new Thread(() => Th2());
            Thread t3 = new Thread(() => Th3());
            //t1.Priority = ThreadPriority.Highest;
            //t2.Priority = ThreadPriority.Highest;
            //t3.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();
            t3.Start();

            Handl.WaitOne();
            Thread t4 = new Thread(() => Th4());
            t4.Start();


            Handl.WaitOne();
            Thread t8 = new Thread(() => Th8());
            Thread t9 = new Thread(() => Th9());
            t8.Start();
            t9.Start();


            Handl.WaitOne();
            Thread t5 = new Thread(() => Th5());
            Thread t6 = new Thread(() => Th6());
            Thread t7 = new Thread(() => Th7());
            t5.Start();
            t6.Start();
            t7.Start();

            Console.ReadKey();

        }
    }
}
