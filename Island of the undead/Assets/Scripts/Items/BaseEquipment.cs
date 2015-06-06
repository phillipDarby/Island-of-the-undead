
using UnityEngine;

    [System.Serializable]
    public class BaseEquipment : BaseItem {
        public enum EquipmentTypes
        {
            HEAD,
            CHEST,
            SHOULDERS,
            LEGS,
            FEET,
            NECK,
            EARRING,
            RING
        }
        
        public EquipmentTypes EquipmentType { get; set; }
        public int SpellEffectID { get; set; }
    }

