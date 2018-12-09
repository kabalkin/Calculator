using System;
using Addons;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueWithFixedLength<string> queue = new QueueWithFixedLength<string>(3);

            queue.Push("first");
            queue.Push("second");
            queue.Push("3");
                Console.WriteLine($"current length = {queue.CurrentCount}");
            queue.Push("four");
                Console.WriteLine($"current length = {queue.CurrentCount}");

            var elements = queue.GetElements();

            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
