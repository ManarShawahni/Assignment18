using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class Inventory
    {
        private List<string> items = new List<string>();

        public void AddItem(string item)
        {
            items.Add(item);
        }

        public void ShowItems()
        {
            foreach (var entry in items)
            {
                Debug.Log(entry);
            }
        }

        public static Inventory operator +(Inventory inv1, Inventory inv2)
        {
            Inventory result = new Inventory();
            result.items.AddRange(inv1.items);
            result.items.AddRange(inv2.items);
            return result;
        }
    }
}
