using System;
using FiniteState;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var miner = new Miner(0);

            for(int i=0; i<20; i++){
                miner.Update();
            }
            Console.ReadLine();
            
        }
    }
}
