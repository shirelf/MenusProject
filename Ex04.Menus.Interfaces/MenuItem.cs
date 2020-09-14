﻿using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : MainMenu, IBackListener
    {
        // Private Members
        //private string m_Title;
        //private List<MenuItem> m_MenuItems;
        private IAction m_Action;
        private IBackListener m_BackListener;

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
        public void Show()
        {
            Console.Clear();
            if(m_MenuItems.Count == 0)
            {
                m_Action.Execute();
            }
            else
            {
                Console.WriteLine(string.Format("---- {0} ----", this.Title));
                Console.WriteLine("Please choose one of the options below (by number):");
                for (int i = 0; i < m_MenuItems.Count; i++)
                {
                    Console.WriteLine(string.Format("{0}. {1}", i + 1, m_MenuItems[i].Title));
                }

                Console.WriteLine("0. Back");
                string userInput = Console.ReadLine();
                while (!InputValidator.IsIndexValid(userInput, m_MenuItems.Count))
                {
                    Console.WriteLine("Invalid index. try again:");
                    userInput = Console.ReadLine();
                }

                int chosenIndex = int.Parse(userInput);
                
                if (chosenIndex == 0)
                {
                    BackListener.BackChosen();
                }
                else
                {
                    m_MenuItems[chosenIndex - 1].Show();
                }
            }
        }

        public void AddNewItems(params MenuItem[] i_ItemToAdd)
        {
            foreach(MenuItem item in i_ItemToAdd)
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

        public IBackListener BackListener
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
