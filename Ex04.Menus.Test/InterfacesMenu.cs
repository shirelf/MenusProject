using System;
using System.Collections.Generic;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfacesMenu
    {
        // Private Members
        private MainMenu m_MainMenu;

        // Constructors
        public InterfacesMenu()
        {
            m_MainMenu = new MainMenu();

            MenuItem versionAndSpaceItem = new MenuItem("Version and Spaces");
            MenuItem dateTimeMenu = new MenuItem("Show Date/Time");

            versionAndSpaceItem.AddNewItems(new MenuItem("Count Spaces", new CountSpaces()), new MenuItem("Show Version", new ShowVersion()));
            dateTimeMenu.AddNewItems(new MenuItem("Show Date", new ShowDate()), new MenuItem("Show Time", new ShowTime()));

            m_MainMenu.AddNewItems(versionAndSpaceItem);
            m_MainMenu.AddNewItems(dateTimeMenu);
        }

        // Properties
        public MainMenu MainMenuList
        {
            get
            {
                return m_MainMenu;
            }

            set
            {
                m_MainMenu = value;
            }
        }
    }
}
