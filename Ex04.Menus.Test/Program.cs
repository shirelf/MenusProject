﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            InterfacesMenu interfacesMenu = new InterfacesMenu();
           // DelegatesMenu delegatesMenu = new DelegatesMenu();
            interfacesMenu.MainMenuList.Show();
            //delegatesMenu.MainMenuList.Show();
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
