using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : INotifyListener
    {
        private string m_Title;
        private List<MenuItem> m_MenuItems;

        public MainMenu(string i_Title, List<MenuItem> i_MenuItems)
        {
            m_Title = i_Title;
            m_MenuItems = i_MenuItems;
            for (int i = 0; i < m_MenuItems.Count; i++)
            {
                m_MenuItems[i].NotifyListeners.Add(this);
            }
        }


        public void ShowMenu()
        {
            string messsage = string.Format("{0} {1} please choose one of the options below: (by number):", m_Title, Environment.NewLine);
            Console.WriteLine(messsage);
            for (int i = 0; i < m_MenuItems.Count; i++)
            {
                Console.WriteLine(string.Format("{0}. {1}",i+1, m_MenuItems[i].Title)); 
            }
            int chosenIndex = int.Parse(Console.ReadLine());
            while(!Valid(chosenIndex))
            {
                chosenIndex = int.Parse(Console.ReadLine());
            }


        }

        void INotifyListener.ReportChosen(int i_Index)
        {
            m_MenuItems[i_Index].execute();
        }
    }
}
