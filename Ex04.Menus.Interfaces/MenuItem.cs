using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private string m_Title;
        List<INotifyListener> m_NotifyListeners;
        List<MenuItem> m_MenuItems;
        IAction m_Action;

        public MenuItem(string i_Title, IAction i_Action)
        {
            m_Title = i_Title;
            m_Action = i_Action;
        }

        public MenuItem(string i_Title, List<MenuItem> i_MenuItems)
        {
            m_Title = i_Title;
            m_MenuItems = i_MenuItems;
        }

        public void Execute()
        {
            if (m_MenuItems.Count > 0)
            {
                // show my menu options
            }
            else
            {
                m_Action.Execute();
                // execute my action
            }
        }

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public List<INotifyListener> NotifyListeners
        {
            get { return m_NotifyListeners; }
        }
    }
}
