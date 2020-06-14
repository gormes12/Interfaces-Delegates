using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    class DelegeteMenuTest
    {
        private Menu m_MainMenu;

        public DelegeteMenuTest()
        {
            m_MainMenu = createMainMenu();
        }

        private Menu createMainMenu()
        {
            MainMenu mainMenu = new MainMenu("Main Menu");
            Menu versionAndDigitsMenu = new Menu("Version and Digits");
            LeafItem countCapitalItem = new LeafItem("Count Capital");
            countCapitalItem.ItemActions += new Action(countCapitals);
            versionAndDigitsMenu.AddMenuItems(countCapitalItem);
            LeafItem showVersionItem = new LeafItem("Show Version");
            showVersionItem.ItemActions += new Action(showVersion);
            versionAndDigitsMenu.AddMenuItems(showVersionItem);
            mainMenu.AddMenuItems(versionAndDigitsMenu);
            Menu showDateTimeMenu = new Menu("Show Date/Time");
            LeafItem showTimeItem = new LeafItem("Show Time");
            showTimeItem.ItemActions += new Action(showTime);
            showDateTimeMenu.AddMenuItems(showTimeItem);
            LeafItem showDateItem = new LeafItem("Date Time");
            showDateItem.ItemActions += new Action(showDate);
            showDateTimeMenu.AddMenuItems(showDateItem);
            mainMenu.AddMenuItems(showDateTimeMenu);

            return mainMenu;
        }

        private void showDate()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime.ToString("dd/MM/yyyy"));
        }

        private void showTime()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime.ToString("HH:mm"));
        }

        private void showVersion()
        {
            Console.WriteLine("Version: 20.2.4.30620");
        }

        private void countCapitals()
        {
            string sentence;
            int counter = 0;
            Console.WriteLine("Please insert a sentence");
            sentence = Console.ReadLine();
            foreach(Char c in sentence)
            {
                if(char.IsUpper(c))
                {
                    counter++;
                }
            }

            Console.WriteLine("There are {0} capital letters!", counter);
        }

        public void ShowMainMenu()
        {
            m_MainMenu.Show();
        }
    }
}
