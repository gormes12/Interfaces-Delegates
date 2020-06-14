using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class LeafItem : MenuItem
    {
        public event Action ItemActions;

        public override void ExecuteAction()
        {
            OnItemActions();
        }

        protected virtual void OnItemActions()
        {
            if(ItemActions != null)
            {
                Console.WriteLine(this.m_MenuItemTitle);
                ItemActions.Invoke();
            }
        }

        public LeafItem(string i_ItemTitle) : base(i_ItemTitle) // c'tor
        {

        }

    }
}
