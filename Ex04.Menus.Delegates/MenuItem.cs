using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MenuItem : MainMenu
    {
        public event Action ActionActivated;

        // Constructors
        public MenuItem(string i_Title) : base(i_Title)
        {
        }
 
        // Public Methods
        public override void Show()
        {
            Console.Clear();
            if (m_MenuItems.Count == 0)
            {
                ActionActivated.Invoke();
            }
            else
            {
                base.Show();
            }
        }
    }
}
