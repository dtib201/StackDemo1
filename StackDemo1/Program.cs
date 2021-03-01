using System;

namespace StackDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            //TODO
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
                if (isEmpty())
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

            private bool isFull()
            {
                return (maxSize - 1 == top);
            }

            private bool isEmpty()
            {
                return (top == -1);
            }


        }
    }
}
