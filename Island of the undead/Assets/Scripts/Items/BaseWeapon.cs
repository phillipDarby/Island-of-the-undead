using UnityEngine;


    public class BaseWeapon : BaseItem {

        public enum WeaponTypes
        {
            SWORD,
            STAFF,
            DAGGER,
            BOW,
            SHIELD,
            POLEARM
        }

        public WeaponTypes WeaponType { get; set; }
        public int SpellEffectID { get; set; }
    }

