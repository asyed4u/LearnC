using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnC
{
    class Program
    {
        static void Main(string[] args)
        {
        }


    }


    abstract class life
    {
        public abstract void eat();
        public void sound()
        {
            Console.WriteLine("human can speak");
        }
    }
}
