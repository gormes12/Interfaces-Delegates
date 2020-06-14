using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public interface IAct
    {
        void Execute();

        //string Name
        //{
        //    get;
        //}
    }
    class LeafItem : IAct
    {
        private string m_itemName;

        public string Name
        {
            get
            {
                return m_itemName;
            }
        }
        public override string ToString()
        {
            return m_itemName;
        }

        public void Execute()
        {

        }

    }

}
