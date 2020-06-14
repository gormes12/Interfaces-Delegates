using System;
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
            //DelegeteMenuTest deletateManu = new DelegeteMenuTest();
            //deletateManu.ShowMainMenu();
            InterfaceMenuTest interfaceMenu = new InterfaceMenuTest();
            interfaceMenu.ShowMainMenu();
        }
    }
}
