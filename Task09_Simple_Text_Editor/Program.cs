using System;
using System.Collections.Generic;
using System.Linq;

namespace Task09_Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> textEdit = new Stack<string>();
            string text = string.Empty;

            int comandsNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= comandsNumber; i++)
            {
                string[] comand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string typeComand = comand[0];

                switch (typeComand)
                {
                    case "1":
                        string textToAdd = comand[1];
                        textEdit.Push(textToAdd);
                        textEdit.Push("+");
                        text = text + textToAdd;
                        break;

                    case "2":
                        int charsToDelete = int.Parse(comand[1]);
                        string textToErace = text.Substring(text.Length - charsToDelete);
                        textEdit.Push(textToErace);
                        textEdit.Push("-");
                        text = text.Substring(0, text.Length - charsToDelete);
                        break;

                    case "3":
                        int index = int.Parse(comand[1]);
                        Console.WriteLine(text[index - 1]);
                        break;

                    case "4":
                        string typeCorection = textEdit.Pop();
                        string textCorection = textEdit.Pop();

                        switch (typeCorection)
                        {
                            case "+":
                                text = text.Substring(0, text.Length - textCorection.Length);
                                break;

                            case "-":
                                text = text + textCorection;
                                break;
                            
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
