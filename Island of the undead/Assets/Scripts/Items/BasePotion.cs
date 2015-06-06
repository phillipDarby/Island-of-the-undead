using UnityEngine;


    public class BasePotion : BaseItem {

        public enum PotionTypes
        {
            HEALTH,
            ENERGY,
            STRENGTH,
            INTELLECT,
            VITALITY,
            ENDURANCE,
            SPEED
        }

        public PotionTypes PotionType { get; set; }
        public int SpellEffectID { get; set; }
    }

