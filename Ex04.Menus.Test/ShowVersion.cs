using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersion : IAction
    {
        public static void Activate()
        {
            Console.Clear();
            Console.WriteLine(" ---- Show Version ----");
            Console.WriteLine("Version: 20.3.4.8920");
        }

        void IAction.Execute()
        {
            Activate();
        }
    }
}