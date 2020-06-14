using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;
namespace Ex04.Menus.Test
{
    class InterfaceMenuTest : IAct
    {
        public void Execute()
        {
            Console.WriteLine("Version: 20.2.4.30620");
        }
    }
}
