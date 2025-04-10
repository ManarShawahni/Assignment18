using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class GameInventory : MonoBehaviour
    {
        void Start()
        {
            var potions = new Inventory();
            potions.AddItem("Healing Potion");
            potions.AddItem("Strength Potion");

            var elixirs = new Inventory();
            elixirs.AddItem("Elixir");
            elixirs.AddItem("Dark Elixir");

            var combined = potions + elixirs;

            combined.ShowItems();
        }
    }
}
