using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8
{
    class Program
    {

        public static void Main(string[] args)
        {

            MyQueue queue = new MyQueue();
            queue.Dequeue();
            queue.Enqueue(3);
            queue.Enqueue(16);
            queue.Enqueue(17);
            queue.Enqueue(5);
            queue.Enqueue(8);
            queue.Dequeue();
            queue.Counts();

            foreach (var item in queue.Lista)
            {
                Console.WriteLine(item);

            }

            /*MyStack stack = new MyStack();
            stack.Pop();
            stack.Push(3);
            stack.Push(16);
            stack.Push(17);
            stack.Push(5);
            stack.Pop();

            foreach (var item in stack.Lista)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Dati elementul ");
            int x = int.Parse(Console.ReadLine());

            stack.Contain(x);*/

        }
    }
}
