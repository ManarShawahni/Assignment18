using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

namespace Assignment18
{
    public class GenericsTest : MonoBehaviour
    {
        void Start()
        {
            var container = new GameContainer<string>();
            container.SetItem("Healing Potion");

            string stored = container.GetItem();
            Debug.Log("Stored item: " + stored);

            string description = GameUtils.DescribeItem(stored);
            Debug.Log(description);
        }
    }
}
