using Ex04.Menus.Interfaces;
using System;


namespace Ex04.Menus.Test
{
    public class ShowDate : IAction
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine(" ---- Show Date ----");
            Console.WriteLine(DateTime.Now.ToShortDateString());
            System.Threading.Thread.Sleep(2000);
        }
        void IAction.Execute()
        {
            Show();
        }
    }
}
