using UnityEngine;
using UnityEngine.UI;


    public class CreateNewCharacter : MonoBehaviour
    {

        private BasePlayer newPlayer;
        private bool isMageClass;
        private bool isWarriorClass;
        private string playerName = "Enter Name";

        public Text DescriptionText;
        public Text StatsText;
        public GameObject Description;
        public GameObject Stats;
        public Text PlayerName;
        public bool IsMage { get; set; }
        public bool IsWarrior { get; set; }

        // Use this for initialization
        void Start () 
        {
	        newPlayer = new BasePlayer();
            DescriptionText = Description.GetComponentInChildren<Text>();
            StatsText = Stats.GetComponentInChildren<Text>();
            
        }
	
        // Update is called once per frame
        void Update ()
        {
            
        }

        //void OnGUI()
        //{
            
        //    //playerName = GUILayout.TextArea(playerName,15);
        //    isMageClass = GUILayout.Toggle(isMageClass, "Mage Class");
        //    isWarriorClass = GUILayout.Toggle(isWarriorClass, "Warrior Class");
        //    if (GUILayout.Button("Create"))
        //    {
        //        if (isMageClass)
        //        {
        //            newPlayer.PlayerClass = new BaseMageClass();
        //        }
        //        else if (isWarriorClass)
        //        {
        //            newPlayer.PlayerClass = new BaseWarriorClass();
        //        }
        //        CreateNewPlayer();
        //        StoreNewPlayerInfo();
        //        SaveInformation.SaveAllInformation();

                
        //    }
        //    if (GUILayout.Button("LOAD"))
        //    {
        //        Application.LoadLevel("Test2");
        //    }
        //}

        private void StoreNewPlayerInfo()
        {
            GameInformation.PlayerName = newPlayer.PlayerName;
            GameInformation.PlayerLevel = newPlayer.PlayerLevel;
            GameInformation.Stamina = newPlayer.Stamina;
            GameInformation.Endurance = newPlayer.Endurance;
            GameInformation.Intellect = newPlayer.Intellect;
            GameInformation.Strength = newPlayer.Strength;
            GameInformation.Agility = newPlayer.Agility;
            GameInformation.Resistance = newPlayer.Resistance;
            GameInformation.Gold = newPlayer.gold;
        }

        private void CreateNewPlayer()
        {
            newPlayer.PlayerLevel = 1;
            newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
            newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
            newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
            newPlayer.Strength = newPlayer.PlayerClass.Strength;
            newPlayer.Agility = newPlayer.PlayerClass.Agility;
            newPlayer.Resistance = newPlayer.PlayerClass.Resistance;
            newPlayer.gold = 10;
            newPlayer.PlayerName = playerName;
            Debug.Log("Player Name: " + newPlayer.PlayerName);
            Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
            Debug.Log("Player Level: " + newPlayer.PlayerLevel);
            Debug.Log("Player Stamina: " + newPlayer.Stamina);
            Debug.Log("Player Endurance: " + newPlayer.Endurance);
            Debug.Log("Player Intellect: " + newPlayer.Intellect);
            Debug.Log("Player Strength: " + newPlayer.Strength);
            Debug.Log("Player Agility: " + newPlayer.Agility);
            Debug.Log("Player Resistance: " + newPlayer.Resistance);
            Debug.Log("Player Gold: " + newPlayer.gold);
        }

        public void UpdateDescription()
        {

            if (IsMage)
            {
                newPlayer.PlayerClass = new BaseMageClass();
                DescriptionText.text = newPlayer.PlayerClass.CharacterClassDescription;
                StatsText.text = "Stamina: " + newPlayer.PlayerClass.Stamina.ToString() + "\n" +
                                 "Endurance: " + newPlayer.PlayerClass.Endurance.ToString() + "\n"+
                                 "Strength: " + newPlayer.PlayerClass.Strength.ToString() + "\n"+
                                 "Intellect: " + newPlayer.PlayerClass.Intellect.ToString() + "\n"+
                                 "Agility: " + newPlayer.PlayerClass.Agility.ToString() + "\n"+
                                 "Resistance: " + newPlayer.PlayerClass.Resistance.ToString() + "\n";
                Debug.Log("You Selected Mage Class");
                IsWarrior = false;
            }
            if (IsWarrior)
            {
                newPlayer.PlayerClass = new BaseWarriorClass();
                DescriptionText.text = newPlayer.PlayerClass.CharacterClassDescription;
                StatsText.text = "Stamina: " + newPlayer.PlayerClass.Stamina.ToString() + "\n" +
                                 "Endurance: " + newPlayer.PlayerClass.Endurance.ToString() + "\n" +
                                 "Strength: " + newPlayer.PlayerClass.Strength.ToString() + "\n" +
                                 "Intellect: " + newPlayer.PlayerClass.Intellect.ToString() + "\n" +
                                 "Agility: " + newPlayer.PlayerClass.Agility.ToString() + "\n" +
                                 "Resistance: " + newPlayer.PlayerClass.Resistance.ToString() + "\n";
                Debug.Log("You Selected Warrior Class");
                IsMage = false;
            }
            
        }
        public void test()
        {
            if (IsMage)
            {
                newPlayer.PlayerClass = new BaseMageClass();
                DescriptionText.text = newPlayer.PlayerClass.CharacterClassDescription;
                StatsText.text = "Stamina: " + newPlayer.PlayerClass.Stamina.ToString() + "\n" +
                                 "Endurance: " + newPlayer.PlayerClass.Endurance.ToString() + "\n" +
                                 "Strength: " + newPlayer.PlayerClass.Strength.ToString() + "\n" +
                                 "Intellect: " + newPlayer.PlayerClass.Intellect.ToString() + "\n" +
                                 "Agility: " + newPlayer.PlayerClass.Agility.ToString() + "\n" +
                                 "Resistance: " + newPlayer.PlayerClass.Resistance.ToString() + "\n";
                Debug.Log("You Selected Mage Class");
            }
            if(IsWarrior)
            {
                newPlayer.PlayerClass = new BaseWarriorClass();
                DescriptionText.text = newPlayer.PlayerClass.CharacterClassDescription;
                StatsText.text = "Stamina: " + newPlayer.PlayerClass.Stamina.ToString() + "\n" +
                                 "Endurance: " + newPlayer.PlayerClass.Endurance.ToString() + "\n" +
                                 "Strength: " + newPlayer.PlayerClass.Strength.ToString() + "\n" +
                                 "Intellect: " + newPlayer.PlayerClass.Intellect.ToString() + "\n" +
                                 "Agility: " + newPlayer.PlayerClass.Agility.ToString() + "\n" +
                                 "Resistance: " + newPlayer.PlayerClass.Resistance.ToString() + "\n";
                Debug.Log("You Selected Warrior Class");
            }
            playerName = PlayerName.text;
            Debug.Log(playerName);
            CreateNewPlayer();
            StoreNewPlayerInfo();
            SaveInformation.SaveAllInformation();
        }
    }

