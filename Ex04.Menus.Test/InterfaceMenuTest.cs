using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceMenuTest : IActionObserver
    {
        private MainMenu m_MainMenu;

        public InterfaceMenuTest()
        {
            m_MainMenu = createMainMenu();
        }

        private MainMenu createMainMenu()
        {
            MainMenu mainMenu = new MainMenu("Interface - Main Menu");
            Menu versionAndDigitsMenu = new Menu("Version and Digits");
            Menu showDateTimeMenu = new Menu("Show Date/Time");
            LeafItem countCapitalItem = new LeafItem("Count Capital");
            LeafItem showVersionItem = new LeafItem("Show Version");
            LeafItem showTimeItem = new LeafItem("Show Time");
            LeafItem showDateItem = new LeafItem("Show Date");

            countCapitalItem.AttachObserver(this as IActionObserver);
            showVersionItem.AttachObserver(this as IActionObserver);
            showTimeItem.AttachObserver(this as IActionObserver);
            showDateItem.AttachObserver(this as IActionObserver);
            versionAndDigitsMenu.AddMenuItems(countCapitalItem);
            versionAndDigitsMenu.AddMenuItems(showVersionItem);
            showDateTimeMenu.AddMenuItems(showTimeItem);
            showDateTimeMenu.AddMenuItems(showDateItem);
            mainMenu.AddMenuItems(versionAndDigitsMenu);
            mainMenu.AddMenuItems(showDateTimeMenu);

            return mainMenu;
        }

        public void MakeAction(string i_ActionTitle)
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
            foreach (char c in sentence)
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
            m_MainMenu.Show();
        }
    }
}
