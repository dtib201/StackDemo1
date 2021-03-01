using System;

namespace StackDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack theStack = new Stack(4);
            theStack.Push("Star Wars");
            theStack.Push("Jaws");
            theStack.Push("Jaws 2");
            theStack.Push("Titanic");
            theStack.Push("Rocky");

            Console.WriteLine("+++++++++++++++++++++++++++++\nAbout to peek: \n");
            Console.WriteLine($"'{ theStack.Peek() }' is at the top of the stack.\n' ");


            Console.WriteLine("+++++++++++++++++++++++++++++\nThe Stack contains: \n");

            while (!theStack.IsEmpty())
            {
                string movie = theStack.Pop();
                Console.WriteLine(movie);
            }
        }

        public class Stack
        {
            private int maxSize;
            private string[] stackArray;
            private int top;

            public Stack(int size)
            {
                maxSize = size;
                stackArray = new string[maxSize];
                top = -1;
            }
            
            public void Push(string m)
            {
                // Check if the stack is full
                if (isFull()){
                    Console.WriteLine("This stack is full");
                }
                else {
                    top++;
                    stackArray[top] = m;
                }
            }


            public string Pop()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("The stack is empty");
                    return "--";
                }
                else
                {
                    int oldTop = top;
                    top--;
                    return stackArray[oldTop];
                }
            }

            public string Peek()
            {
                return stackArray[top];
            }

            private bool isFull()
            {
                return (maxSize - 1 == top);
            }

            public bool IsEmpty()
            {
                return (top == -1);
            }


        }
    }
}
