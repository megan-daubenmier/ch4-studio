using System;
using System.Collections.Generic;
using System.Text;

namespace ch4_studio
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<MenuItem> myItems = new List<MenuItem>();
            MenuItem item1 = new MenuItem("Mashed potatoes");
            MenuItem item2 = new MenuItem("Green eggs and ham");
            MenuItem item3 = new MenuItem("Spaghetti");
            myItems.Add(item1);
            myItems.Add(item2);
            Menu myMenu = new Menu(myItems);
            Console.WriteLine(myMenu.lastUpdated);
            Console.WriteLine(myMenu.addItemToMenu(item3));
            Console.WriteLine(myMenu.lastUpdated);
        }
    }
}
