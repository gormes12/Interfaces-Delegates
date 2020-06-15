using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class LeafItem : MenuItem
    {
        private readonly List<IActionObserver> m_ActionObserve = new List<IActionObserver>();

        public LeafItem(string i_ItemTitle) : base(i_ItemTitle)
        {
        }

        public void AttachObserver(IActionObserver i_ActionObserver)
        {
            m_ActionObserve.Add(i_ActionObserver);
        }

        public void DetachObserver(IActionObserver i_ActionObserver)
        {
            m_ActionObserve.Remove(i_ActionObserver);
        }

        private void notifyActionObservers()
        {
            foreach (IActionObserver observer in m_ActionObserve)
            {
                observer.MakeAction(m_MenuItemTitle);
            }
        }

        public override void ExecuteAction()
        {
            notifyActionObservers();
        }
    }
}
