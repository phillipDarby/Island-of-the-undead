
using UnityEngine;



    public class BasePlayer
    {
        public string PlayerName { get; set; }
        public int PlayerLevel { get; set; }
        public BaseCharacterClass PlayerClass { get; set; }

        public int Stamina { get; set; } // health modifier
        public int Endurance { get; set; } // energy modifier
        public int Intellect { get; set; } // magical damage modifier
        public int Strength { get; set; } // physical damage
        public int Agility { get; set; } // quickness
        public int Resistance { get; set; } // all damage reduction

        public int gold { get; set; } // currency

        public float CurrentXP { get; set; }
        public float RequiredXP { get; set; }
        public int StatPointsToAllocate { get; set; }
    }

