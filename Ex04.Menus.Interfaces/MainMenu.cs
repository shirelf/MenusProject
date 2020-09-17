using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : IBackListener
    {
        // Private Members
        protected string m_Title;
        protected List<MenuItem> m_MenuItems;
        protected IBackListener m_BackListener;
       
        // Constructors
        public MainMenu()
        {
            m_Title = "Main Menu";
            m_MenuItems = new List<MenuItem>();
        }

        // Public Methods
        public virtual void Show()
        {
            Console.Clear();
            Console.WriteLine(string.Format("---- {0} ----", m_Title));
            Console.WriteLine("Please choose one of the options below (by number):");
            for (int i = 0; i < m_MenuItems.Count; i++)
            {
                Console.WriteLine(string.Format("{0}. {1}", i + 1, m_MenuItems[i].Title));
            }

            Console.WriteLine(string.Format("0. Exit"));
            string userInput = Console.ReadLine();
            while (!InputValidator.IsIndexValid(userInput, m_MenuItems.Count))
            {
                Console.WriteLine("Invalid index. try again:");
                userInput = Console.ReadLine();
            }

            int chosenIndex = int.Parse(userInput);

            if (chosenIndex == 0) 
            {
                if(this.GetType() == typeof(MainMenu))
                {
                    Environment.Exit(-1);
                }
                else if(this.GetType() == typeof(MenuItem))
                {
                    BackListener.BackChosen();
                }
            }
            else
            {
                m_MenuItems[chosenIndex - 1].Show();
            }
        }

        public void AddNewItems(params MenuItem[] i_ItemToAdd)
        {
            foreach (MenuItem item in i_ItemToAdd)
            {
                m_MenuItems.Add(item);
                item.BackListener = this;
            }
        }

        void IBackListener.BackChosen()
        {
            Show();
        }

        // Properties
        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public List<MenuItem> MenuItemsList
        {
            get
            {
                return m_MenuItems;
            }

            set
            {
                m_MenuItems = value;
            }
        }

        public virtual IBackListener BackListener
        {
            get
            {
                return m_BackListener;
            }

            set
            {
                m_BackListener = value;
            }
        }
    }
}
