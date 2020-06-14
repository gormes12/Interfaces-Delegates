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
        private List<MenuItem> m_MenuItems;

        public Menu(string i_MenuTitle) : base(i_MenuTitle)
        {
            m_MenuItems = new List<MenuItem>();
        }

        public void AddMenuItems(MenuItem i_ItemToAdd)
        {
            m_MenuItems.Add(i_ItemToAdd);
        }

        public void Show()
        {
            int optionSelected;
            do
            {
                optionSelected = showOptionsAndGetChoise();
                if (optionSelected != k_ExitOrBackIndex)
                {
                    Console.Clear();
                    m_MenuItems[optionSelected - 1].ExecuteAction();
                    if (m_MenuItems[optionSelected - 1] is LeafItem)
                    {
                        Console.WriteLine("Press any key to go back");
                        Console.ReadKey();
                    }
                }
                Console.Clear();
            } while (optionSelected != k_ExitOrBackIndex);
            

        }

        public override void ExecuteAction()
        {
            this.Show();
        }

        private int showOptionsAndGetChoise()
        {
            int optionSelected;
            Console.WriteLine(this.ToString());
            Console.WriteLine("Please choose one of the following options:");
            uint lineNumber;

            Console.WriteLine("0. {0}", (this is MainMenu) ? "Exit" : "Back");
            lineNumber = 1;
            foreach (MenuItem item in m_MenuItems)
            {
                Console.WriteLine("{0}. {1}", lineNumber++, item.ToString());
            }
            optionSelected = GetValidInputs.GetValidInputNumber(0, m_MenuItems.Count);
            return optionSelected;
        }
    }
}
