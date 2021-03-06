﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegeteMenuTest
    {
        private MainMenu m_MainMenu;

        public DelegeteMenuTest()
        {
            m_MainMenu = createMainMenu();
        }

        private MainMenu createMainMenu()
        {
            MainMenu mainMenu = new MainMenu("Delegete -  Main Menu");
            Menu versionAndDigitsMenu = new Menu("Version and Digits");
            Menu showDateTimeMenu = new Menu("Show Date/Time");
            LeafItem countCapitalItem = new LeafItem("Count Capital");
            LeafItem showVersionItem = new LeafItem("Show Version");
            LeafItem showTimeItem = new LeafItem("Show Time");
            LeafItem showDateItem = new LeafItem("Show Date");

            countCapitalItem.ItemClicked += countCapitalItem_ItemClicked;
            showVersionItem.ItemClicked += showVersionItem_ItemClicked;
            showTimeItem.ItemClicked += showTimeItem_ItemClicked;
            showDateItem.ItemClicked += showDateItem_ItemClicked;
            versionAndDigitsMenu.AddMenuItems(countCapitalItem);
            versionAndDigitsMenu.AddMenuItems(showVersionItem);
            showDateTimeMenu.AddMenuItems(showTimeItem);
            showDateTimeMenu.AddMenuItems(showDateItem);
            mainMenu.AddMenuItems(versionAndDigitsMenu);
            mainMenu.AddMenuItems(showDateTimeMenu);

            return mainMenu;
        }

        private void countCapitalItem_ItemClicked()
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

        private void showVersionItem_ItemClicked()
        {
            Console.WriteLine("Version: 20.2.4.30620");
        }

        private void showTimeItem_ItemClicked()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime.ToString("HH:mm"));
        }

        private void showDateItem_ItemClicked()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime.ToString("dd/MM/yyyy"));
        }

        public void ShowMainMenu()
        {
            m_MainMenu.Show();
        }
    }
}
