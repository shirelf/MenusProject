using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : IAction
    {

        public static void Activate()
        {
            Console.Clear();
            Console.WriteLine(" ---- Show Date ----");
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }

        void IAction.Execute()
        {
            Activate();
        }
    }
}
