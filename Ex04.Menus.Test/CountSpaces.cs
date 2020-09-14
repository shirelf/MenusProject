using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountSpaces : IAction
    {
        public void Activate()
        {
            Console.WriteLine("---- Count Spaces ----");
            int spaceCount = 0;
            string userInput;
            do
            {
                Console.Write("Enter some text: ");
                userInput = Console.ReadLine();
            }
            while(string.IsNullOrEmpty(userInput));
            foreach(char currentChar in userInput)
            {
                if(currentChar == ' ')
                {
                    spaceCount++;
                }
            }

            Console.WriteLine(string.Format("The text contains {0} spaces.", spaceCount));
        }

        void IAction.Execute()
        {
            Activate();
        }
    }
}