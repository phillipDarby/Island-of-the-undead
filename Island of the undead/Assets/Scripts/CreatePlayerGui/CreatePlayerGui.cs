using UnityEngine;
using System.Collections;

public class CreatePlayerGui : MonoBehaviour {

    public enum CreateAPlayerStates
    {
        CLASSSELECTION, //display all class types
        STATALLOCATION, //allocate stats where player wants
        FINALSETUP      //add name and misc items gender
    }

    private DisplayCreatePlayerFunctions displayFunctions = new DisplayCreatePlayerFunctions();
    public static CreateAPlayerStates currentState;
	// Use this for initialization
	void Start () 
    {
        currentState = CreateAPlayerStates.CLASSSELECTION;
	}
	
	// Update is called once per frame
	void Update () 
    {
	    switch (currentState)
	    {
            case(CreateAPlayerStates.CLASSSELECTION):
	            break;
            case (CreateAPlayerStates.STATALLOCATION):
                break;
            case (CreateAPlayerStates.FINALSETUP):
                break;
	    }
	}

    void OnGUI()
    {
        displayFunctions.DisplayMainItems();
        if (currentState == CreateAPlayerStates.CLASSSELECTION)
        {
            //display class selection function
            displayFunctions.DisplayClassSelections();
        }
        if (currentState == CreateAPlayerStates.STATALLOCATION)
        {
            //display stat selection function
            displayFunctions.DisplayStatAllocation();
        }
        if (currentState == CreateAPlayerStates.FINALSETUP)
        {
            //display final selection function
            displayFunctions.DisplayFinalSetup();
        }
    }
}
