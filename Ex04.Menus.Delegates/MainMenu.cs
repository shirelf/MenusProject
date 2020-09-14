using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        // Private Members
        private string m_Title;
        private List<MenuItem> m_MenuItems;

        // Constructors
        public MainMenu()
        {
            m_Title = "Main Menu";
            m_MenuItems = new List<MenuItem>();
        }

        // Public Methods
        public void Show()
        {
            Console.Clear();
            Console.WriteLine(string.Format("---- {0} ----", m_Title));
            Console.WriteLine("Please choose one of the options below (by number):");
            for (int i = 0; i < m_MenuItems.Count; i++)
            {
                Console.WriteLine(string.Format("{0}. {1}", i + 1, m_MenuItems[i].Title));
            }

            Console.WriteLine("0. Exit");
            string userInput = Console.ReadLine();
            while (!InputValidator.IsIndexValid(userInput, m_MenuItems.Count))
            {
                Console.WriteLine("Invalid index. try again:");
                userInput = Console.ReadLine();
            }

            int chosenIndex = int.Parse(userInput);

            if (chosenIndex == 0)
            {
                Environment.Exit(-1);
            }
            else
            {
                m_MenuItems[chosenIndex - 1].Show();
            }
        }

        public void AddNewMenu(MenuItem i_MenuToAdd)
        {
            m_MenuItems.Add(i_MenuToAdd);
            i_MenuToAdd.BackChosen += OnBackChosen;
        }

        public void AddNewAction(MenuItem i_ActionToAdd, Action OnEventHandler)
        {
            m_MenuItems.Add(i_ActionToAdd);
            i_ActionToAdd.ActionActivated += OnEventHandler;
        }

        private void OnBackChosen()
        {
            this.Show();
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

    }
}
