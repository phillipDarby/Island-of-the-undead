using UnityEngine;


    public class TurnBasedCombatStateMachine : MonoBehaviour
    {
        private bool hasAddedXP = false;
        public enum BattleStates
        {
            START,
            PLAYERCHOICE,
            ENEMYCHOICE,
            LOSE,
            WIN
        }

        private BattleStates currentState;
        


        // Use this for initialization
        void Start ()
        {
            hasAddedXP = false;
            currentState = BattleStates.START;
        }
	
        // Update is called once per frame
        void Update () 
        {
            Debug.Log(currentState);
            switch (currentState)
            {
                case BattleStates.START :
                    //setup battle function
                    break;
                case BattleStates.PLAYERCHOICE:
                    break;
                case BattleStates.ENEMYCHOICE:
                    break;
                case BattleStates.LOSE:
                    break;
                case BattleStates.WIN:
                    if (!hasAddedXP)
                    {
                        IncreaseExperience.AddExperience();
                        hasAddedXP = true;
                    }
                    break;
            }
        }

        void OnGUI()
        {
            if (GUILayout.Button("NEXT STATE"))
            {
                switch (currentState)
                {
                    case BattleStates.START:
                        currentState = BattleStates.PLAYERCHOICE;
                        break;
                    case BattleStates.PLAYERCHOICE:
                        currentState = BattleStates.ENEMYCHOICE;
                        break;
                    case BattleStates.ENEMYCHOICE:
                        currentState = BattleStates.LOSE;
                        break;
                    case BattleStates.LOSE:
                        currentState = BattleStates.WIN;
                        break;
                    case BattleStates.WIN:
                        currentState = BattleStates.START;
                        break;
                }
            }
        }
    }

