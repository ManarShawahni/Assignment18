using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class GameContainer<T>
    {
        private T item;

        public void SetItem(T newItem)
        {
            item = newItem;
        }

        public T GetItem()
        {
            return item;
        }
    }
}
