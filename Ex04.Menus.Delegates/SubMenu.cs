using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Test;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private uint m_MenuLevel;
        private List<MenuItem> m_SubMenuItems;

        public SubMenu(string i_MenuTitle,uint i_MenuLevel) : base(i_MenuTitle)
        {
            m_MenuLevel = i_MenuLevel;
            m_SubMenuItems = new List<MenuItem>();
        }

        public void AddSubMenuItems(MenuItem i_ItemToAdd)
        {
            m_SubMenuItems.Add(i_ItemToAdd);
        }

        public void Show()
        {
            int option;
            Console.WriteLine(this.ToString());
            Console.WriteLine("Please choose one of the following options:");
            uint lineNumber;
            do
            {
                lineNumber = 1;
                Console.WriteLine();
                foreach (MenuItem item in m_SubMenuItems)
                {
                    Console.WriteLine("{0}. {1}", lineNumber++, item.ToString());
                }
                option = GetValidInputs.GetValidInputNumber(0, m_SubMenuItems.Count);

            } while(option != 0)
        }
    }
}
