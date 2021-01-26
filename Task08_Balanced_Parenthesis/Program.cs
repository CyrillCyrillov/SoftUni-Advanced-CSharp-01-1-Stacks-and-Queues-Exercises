using System;
using System.Collections.Generic;
using System.Linq;

namespace Task08_Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequenceParentheses = Console.ReadLine();
            bool isBalanced = true;

            if(sequenceParentheses.Length % 2 != 0)
            {
                isBalanced = false;
            }
            else
            {
                Stack<char> openParentheses = new Stack<char>();
                for (int i = 0; i <= (sequenceParentheses.Length / 2) - 1 ; i++)
                {
                    openParentheses.Push(sequenceParentheses[i]);
                }

                Queue<char> closeParentheses = new Queue<char>();
                for (int i = sequenceParentheses.Length / 2; i <= sequenceParentheses.Length - 1; i++)
                {
                    closeParentheses.Enqueue(sequenceParentheses[i]);
                }

                while(openParentheses.Any())
                {
                    switch (openParentheses.Pop())
                    {
                        case '{':
                            if(closeParentheses.Dequeue() != '}')
                            {
                                isBalanced = false;
                            }
                            break;

                        case '[':
                            if (closeParentheses.Dequeue() != ']')
                            {
                                isBalanced = false;
                            }
                            break;
                        case '(':
                            if (closeParentheses.Dequeue() != ')')
                            {
                                isBalanced = false;
                            }
                            break;

                        default:
                            break;
                    }


                    if(! isBalanced)
                    {
                        break;
                    }
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
