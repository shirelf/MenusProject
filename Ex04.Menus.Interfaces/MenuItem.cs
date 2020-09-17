using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : MainMenu, IBackListener
    {
        private IAction m_Action;

        // Constructors
        public MenuItem(string i_Title) : base()
        {
            m_Title = i_Title;
            m_MenuItems = new List<MenuItem>();
        }

        public MenuItem(string i_Title, IAction i_Action)
        {
            m_Title = i_Title;
            m_Action = i_Action;
            m_MenuItems = new List<MenuItem>();
        }

        // Public Methods
        public override void Show()
        {
            Console.Clear();
            if(m_MenuItems.Count == 0)
            {
                m_Action.Execute();
            }
            else
            {
                base.Show();
            }
        }
    }
}
