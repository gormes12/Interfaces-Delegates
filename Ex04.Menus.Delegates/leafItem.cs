using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class LeafItem : MenuItem
    {
        public event Action ActionChoosed;

        public LeafItem(string i_ItemTitle) : base(i_ItemTitle) // c'tor
        {
        }

        public override void ExecuteAction()
        {
            OnActionChoosed();
        }

        protected virtual void OnActionChoosed()
        {
            if(ActionChoosed != null)
            {
                Console.WriteLine(this.m_MenuItemTitle);
                ActionChoosed.Invoke();
            }
        }
    }
}
