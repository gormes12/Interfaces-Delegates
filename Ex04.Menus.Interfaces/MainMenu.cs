using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : Menu
    {
        public MainMenu(string i_MainMenuTitle) : base(i_MainMenuTitle)
        {
        }

        public void Show()
        {
            this.ExecuteAction();
        }
    }
}
