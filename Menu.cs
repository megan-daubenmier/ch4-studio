using System;
using System.Collections.Generic;

namespace ch4_studio
{
    class Menu
    {
        public DateTime lastUpdated { get; set; }
        public List<MenuItem> Items { get; set; }
        public Menu(List<MenuItem> items)
        {
            Items = items;
            lastUpdated = DateTime.Now;
        }

        public bool addItemToMenu(MenuItem newItem)
        {
            if (!Items.Contains(newItem))
            {
                Items.Add(newItem);
                lastUpdated = DateTime.Now;
                return true;
            } else
            {
                return false;
            }
        }
    }
}
