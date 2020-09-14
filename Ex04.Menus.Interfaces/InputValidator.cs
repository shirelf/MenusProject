using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public static class InputValidator
    {
        public static bool IsIndexValid(string i_Index, int i_MaxValue)
        {
            bool valid = false;
            if (int.TryParse(i_Index, out int result))
            {
                if(result <= i_MaxValue && result >= 0)
                {
                    valid = true;
                }
            }

            return valid;
        }
    }
}
