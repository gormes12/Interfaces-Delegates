using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    class Menu : IAct
    {
        private List<LeafItem> m_Items;
        private string m_MenuItemName;

        public string Name
        {
            get
            {
                return m_MenuItemName;
            }
        }

        public override string ToString()
        {
            return m_MenuItemName;
        }

        public void Execute()
        {

        }
    }
}
