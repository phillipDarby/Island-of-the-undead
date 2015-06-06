using System;
using System.Collections.Generic;
using UnityEngine;

    [System.Serializable]
    public class BaseItem {

        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int ItemID { get; set; }
        public ItemTypes ItemType { get; set; }
        public int Stamina { get; set; } // health modifier
        public int Endurance { get; set; } // energy modifier
        public int Intellect { get; set; } // magical damage modifier
        public int Strength { get; set; } // physical damage

        public enum ItemTypes
        {
            EQUIPMENT,
            WEAPON,
            SCROLL,
            POTION,
            CHEST
        }

        public BaseItem()
        {
            
        }
        public BaseItem(Dictionary<string,string> itemsdictionary)
        {
            ItemName = itemsdictionary["ItemName"];
            ItemID = int.Parse(itemsdictionary["ItemID"]);
            ItemType = (ItemTypes)System.Enum.Parse(typeof(BaseItem.ItemTypes),itemsdictionary["ItemName"]);
        }
    }

