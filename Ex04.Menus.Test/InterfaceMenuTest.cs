using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;
namespace Ex04.Menus.Test
{
    class InterfaceMenuTest : IActionObserver
    {
        private MainMenu m_MainMenu;

        public InterfaceMenuTest()
        {
            m_MainMenu = createMainMenu();
        }

        private MainMenu createMainMenu()
        {
            MainMenu mainMenu = new MainMenu("Main Menu");
            Menu versionAndDigitsMenu = new Menu("Version and Digits");
            LeafItem countCapitalItem = new LeafItem("Count Capital");
            countCapitalItem.AttachObserver(this as IActionObserver);
            versionAndDigitsMenu.AddMenuItems(countCapitalItem);
            LeafItem showVersionItem = new LeafItem("Show Version");
            showVersionItem.AttachObserver(this as IActionObserver);
            versionAndDigitsMenu.AddMenuItems(showVersionItem);
            mainMenu.AddMenuItems(versionAndDigitsMenu);
            Menu showDateTimeMenu = new Menu("Show Date/Time");
            LeafItem showTimeItem = new LeafItem("Show Time");
            showTimeItem.AttachObserver(this as IActionObserver);
            showDateTimeMenu.AddMenuItems(showTimeItem);
            LeafItem showDateItem = new LeafItem("Show Date");
            showDateItem.AttachObserver(this as IActionObserver);
            showDateTimeMenu.AddMenuItems(showDateItem);
            mainMenu.AddMenuItems(showDateTimeMenu);

            return mainMenu;
        }

        public void makeAction(string i_ActionTitle)
        {
            Console.WriteLine(i_ActionTitle);
            switch(i_ActionTitle)
            {
                case "Count Capital":
                    {
                        countCapitals();
                        break;
                    }
                case "Show Version":
                    {
                        showVersion();
                        break;
                    }
                case "Show Time":
                    {
                        showTime();
                        break;
                    }
                case "Show Date":
                    {
                        showDate();
                        break;
                    }
                    
            }
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
            foreach (Char c in sentence)
            {
                if (char.IsUpper(c))
                {
                    counter++;
                }
            }

            Console.WriteLine("There are {0} capital letters!", counter);
        }

        public void ShowMainMenu()
        {
            m_MainMenu.ShowMainMenu();
        }
    }
}
