using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class MyGarbageCollector
    {
        private const int maxGarbage = 1000;
        public  void ShowMemoryUsage()
        {
            MyGarbageCollector mgb = new MyGarbageCollector();
            Console.WriteLine($"The highest generation is {GC.MaxGeneration}");
            MakeSomeGarbage();
            Console.WriteLine($"Generation: {GC.GetGeneration(mgb)}");
            Console.WriteLine($"Memory used before collection:       ${GC.GetTotalMemory(false)}");
            GC.Collect(0);
            GC.WaitForPendingFinalizers();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Bob and balibob");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Total memory:       ${GC.GetTotalMemory(false)}");
            Console.WriteLine($"Generation: {GC.GetGeneration(mgb)}");
            GC.Collect(2);
            Console.WriteLine($"Generation: {GC.GetGeneration(mgb)}");
            Console.WriteLine($"Memory used after full collection:   ${GC.GetTotalMemory(true)}");
            GC.WaitForPendingFinalizers();

        }
        void MakeSomeGarbage()
        {
            HomePet tolya;
            for (int i = 0; i < maxGarbage; i++)
            {
                tolya = new HomePet("tolya", "1234567", 16, 229299);
            }
        }
    }
}
