using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class LeafItem : MenuItem
    {
        public event Action ItemClicked;

        public LeafItem(string i_ItemTitle) : base(i_ItemTitle) // c'tor
        {
        }

        public override void ExecuteAction()
        {
            OnItemClicked();
        }

        protected virtual void OnItemClicked()
        {
            if(ItemClicked != null)
            {
                Console.WriteLine(this.m_MenuItemTitle);
                ItemClicked.Invoke();
            }
        }
    }
}
