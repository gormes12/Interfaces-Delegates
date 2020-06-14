using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    class MainMenu
    {
        private List<IAct> m_Items = new List<IAct>();
        private string m_MainName;

        public MainMenu()
        {

        }
    }
}

    //    public void Show()
    //    {
    //        int option = ChooseOption(0, m_Items.Capacity);
    //        Console.WriteLine(m_MainName);
    //        foreach (IAct item in m_Items)
    //        {
    //            Console.WriteLine(item.ToString());
    //        }

    //        do
    //        {

    //        } while ();

    //    }
    //}

