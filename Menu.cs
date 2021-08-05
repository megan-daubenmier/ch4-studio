using System;
using System.Collections.Generic;

namespace ch4_studio
{
    public class Menu
    {
        public DateTime lastUpdated { get; set; }
        public List<MenuItem> Items { get; set; }
        public Menu(List<MenuItem> items)
        {
            Items = items;
            lastUpdated = DateTime.Now;
        }

        public void addItemToMenu(MenuItem newItem)
        {
            if (!Items.Contains(newItem))
            {
                Items.Add(newItem);
                lastUpdated = DateTime.Now;
                Console.WriteLine("New item has been successfully added to menu.");
            }
            else
            {
                Console.WriteLine("Failed to add item to menu. Item is already on menu.");
            }            
        }

        public bool removeItemFromMenu(MenuItem newItem)
        {
            if (Items.Contains(newItem))
            {
                Items.Remove(newItem);
                lastUpdated = DateTime.Now;
                return true;
            }
            else
            {
                return false;
            }
        }

        public DateTime whenLastUpdated(Menu menu)
        {
            return lastUpdated;
        }

        public void printMenu()
        {
            foreach(MenuItem item in Items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
