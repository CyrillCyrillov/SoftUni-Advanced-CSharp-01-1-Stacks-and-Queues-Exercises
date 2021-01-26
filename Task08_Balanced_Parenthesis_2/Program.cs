using System;
using System.Collections.Generic;
using System.Linq;

namespace Task08_Balanced_Parenthesis_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequenceParentheses = Console.ReadLine();

            Stack<char> parentheses = new Stack<char>();
            bool isBalanced = true;

            foreach (char element in sequenceParentheses)
            {
                if(element == '(' || element == '{' || element == '[')
                {
                    parentheses.Push(element);
                }

                else if(!parentheses.Any())
                {
                    isBalanced = false;
                    break;
                   
                }

                else
                {
                    switch (element)
                    {
                        case ')':
                            if(parentheses.Pop() != '(')
                            {
                                isBalanced = false;
                            }
                            break;

                        case '}':
                            if (parentheses.Pop() != '{')
                            {
                                isBalanced = false;
                            }
                            break;

                        case ']':
                            if (parentheses.Pop() != '[')
                            {
                                isBalanced = false;
                            }
                            break;
                        default:
                            break;
                    }
                }

                if(!isBalanced)
                {
                    break;
                }
            }

            if(parentheses.Any())
            {
                isBalanced = false;
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
