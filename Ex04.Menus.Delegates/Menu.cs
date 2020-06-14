using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex04.Menus.Delegates
{
    public class Menu : MenuItem
    {
        private const int k_ExitOrBackIndex = 0;
        private readonly List<MenuItem> r_MenuItems;

        public Menu(string i_MenuTitle) : base(i_MenuTitle) // c'tor
        {
            r_MenuItems = new List<MenuItem>();
        }

        public void AddMenuItems(MenuItem i_ItemToAdd)
        {
            r_MenuItems.Add(i_ItemToAdd);
        }

        private void show()
        {
            int optionSelected;

            do
            {
                optionSelected = showOptionsAndGetChoise();
                if (optionSelected != k_ExitOrBackIndex)
                {
                    Console.Clear();
                    r_MenuItems[optionSelected - 1].ExecuteAction();
                    if (r_MenuItems[optionSelected - 1] is LeafItem)
                    {
                        Console.WriteLine("Press any key to go back");
                        Console.ReadKey();
                    }
                }

                Console.Clear();
            }
            while (optionSelected != k_ExitOrBackIndex);
        }

        public override void ExecuteAction()
        {
            this.show();
        }

        private int showOptionsAndGetChoise()
        {
            int optionSelected;
            uint lineNumber = 1;

            Console.WriteLine(this.ToString());
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("0. {0}", (this is MainMenu) ? "Exit" : "Back");
            foreach (MenuItem item in r_MenuItems)
            {
                Console.WriteLine("{0}. {1}", lineNumber++, item.ToString());
            }

            optionSelected = GetValidInputs.GetValidInputNumber(0, r_MenuItems.Count);
            return optionSelected;
        }
    }
}
