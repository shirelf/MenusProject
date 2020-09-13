using System;
using System.Collections.Generic;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfacesMenu
    {

        public InterfacesMenu()
        {
            List<MenuItem> firstMenu = new List<MenuItem>();
            List<MenuItem> secondMenu = new List<MenuItem>();

            MenuItem countSpaces = new MenuItem("Count Spaces", new CountSpaces());
            MenuItem showVersion = new MenuItem("Show Version", new ShowVersion());
            firstMenu.Add(countSpaces);
            firstMenu.Add(showVersion);

            MenuItem showDateItem = new MenuItem("Show Date", new ShowDate());
            MenuItem showTimeItem = new MenuItem("Show Time", new ShowTime());
            secondMenu.Add(showDateItem);
            secondMenu.Add(showDateItem);

            MenuItem versionAndSpaceItem = new MenuItem("Version and Spaces", firstMenu);
            MenuItem dateTimeMenu = new MenuItem("Show Date/Time", secondMenu);
        }
    }
}
