using UnityEngine;


    public class CreateNewEquipment : MonoBehaviour
    {

        private BaseEquipment newEquipment;
        private string[] itemNames = new string[4]{"Common","Great","Amazing","Insane"};
        private string[] itemDescriptions = new string[2] { "A new cool Item.", "A new not so cool item."};


        // Use this for initialization
        void Start ()
        {
            CreateEquipment();
            Debug.Log(newEquipment.ItemName);
            Debug.Log(newEquipment.ItemDescription);
            Debug.Log(newEquipment.ItemID.ToString());
            Debug.Log(newEquipment.EquipmentType.ToString());
            Debug.Log(newEquipment.Stamina.ToString());
            Debug.Log(newEquipment.Endurance.ToString());
        }

        private void CreateEquipment()
        {
            newEquipment = new BaseEquipment();
            newEquipment.ItemName = itemNames[Random.Range(0, 3)] + " Item";
            newEquipment.ItemID = Random.Range(1, 101);
            
            ChooseItemType();
            newEquipment.ItemDescription = itemDescriptions[Random.Range(0, itemDescriptions.Length)];
            newEquipment.Stamina = Random.Range(1, 11);
            newEquipment.Endurance = Random.Range(1, 11);
            newEquipment.Intellect = Random.Range(1, 11);
            newEquipment.Strength = Random.Range(1, 11);
        }

        private void ChooseItemType()
        {
            int randomTemp = Random.Range(1, 9);
            switch (randomTemp)
            {
                case 1:
                    newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HEAD;
                    break;
                case 2:
                    newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.SHOULDERS;
                    break;
                case 3:
                    newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CHEST;
                    break;
                case 4:
                    newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGS;
                    break;
                case 5:
                    newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.FEET;
                    break;
                case 6:
                    newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.NECK;
                    break;
                case 7:
                    newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.EARRING;
                    break;
                case 8:
                    newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.RING;
                    break;

            }
        }
        // Update is called once per frame
        void Update () {
	
        }
    }

