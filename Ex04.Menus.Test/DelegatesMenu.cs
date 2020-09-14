using System;
using System.Collections.Generic;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegatesMenu
    {
        // Private Members
        private MainMenu m_MainMenu;

        // Constructors
        public DelegatesMenu()
        {
            m_MainMenu = new MainMenu();

            MenuItem versionAndSpaceItem = new MenuItem("Version and Spaces");
            MenuItem dateTimeMenu = new MenuItem("Show Date/Time");

            versionAndSpaceItem.AddNewAction(new MenuItem("Count Spaces"), OnCountSpacesClicked);
            versionAndSpaceItem.AddNewAction(new MenuItem("Show Version"), OnShowVersionClicked);
            dateTimeMenu.AddNewAction(new MenuItem("Show Date"), OnShowDateClicked);
            dateTimeMenu.AddNewAction(new MenuItem("Show Time"), OnShowTimeClicked);

            m_MainMenu.AddNewMenu(versionAndSpaceItem);
            m_MainMenu.AddNewMenu(dateTimeMenu);
        }

        private void OnShowDateClicked()
        {
            ShowDate.Activate();
        }

        private void OnShowTimeClicked()
        {
            ShowTime.Activate();
        }

        private void OnCountSpacesClicked()
        {
            ShowDate.Activate();
        }

        private void OnShowVersionClicked()
        {
            ShowTime.Activate();
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
