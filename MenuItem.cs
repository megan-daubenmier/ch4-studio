using System;
using System.Collections.Generic;
using System.Text;

namespace ch4_studio
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool isNew { get; set; } = true;

        public MenuItem(string name)
        {
            Name = name;
        }

        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public MenuItem(string name, double price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }

        public MenuItem(string name, double price, string description, string category)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
        }

        public bool isItemNew(MenuItem item)
        {
            return isNew;
        }

        public override string ToString()
        {
            String menuString = "\n" + Name + ": " + "\nCategory: " + Category + "\nDescription: " + Description + "\nPrice: " + Price;
            if (isNew)
            {
                menuString += "\n***NEW ITEM!!***";
            }

            return menuString;
        }

        public override bool Equals(object obj)
        {
            return obj is MenuItem item &&
                   Name == item.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

    }
}
