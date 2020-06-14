using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        protected string m_MenuItemTitle;

        public MenuItem(string i_MenuItemTitle)
        {
            m_MenuItemTitle = i_MenuItemTitle;
        }

        public abstract void ExecuteAction();

        public override string ToString()
        {
            return m_MenuItemTitle;
        }
    }
}
