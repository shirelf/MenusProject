using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : IAction
    {
        public static void Activate()
        {
            Console.Clear();
            Console.WriteLine(" ---- Show Time ----");
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        void IAction.Execute()
        {
            Activate();
        }
    }
}