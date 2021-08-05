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

        public List<bool> addItemsToMenu(List<MenuItem> newItems)
        {
            List<bool> results = new List<bool>();

            foreach(MenuItem item in newItems)
            {
                if (!Items.Contains(item))
                {
                    Items.Add(item);
                    lastUpdated = DateTime.Now;
                    results.Add(true);
                }
                else
                {
                    results.Add(false);
                }
            }

            return results;
            
        }
    }
}
