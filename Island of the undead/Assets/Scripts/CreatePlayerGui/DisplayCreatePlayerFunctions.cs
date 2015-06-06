using UnityEngine;
using System.Collections;

public class DisplayCreatePlayerFunctions
{
    private StatAllocationModule statAllocationModule = new StatAllocationModule();
    private int classSelection;
    private string[] classSelectionNames = new string[] { "Mage", "Warrior", "Archer", "Rogue", "Warlock", "Paladin" };
    private string playerFirstName ="FirstName";
    private string playerLastName="LastName";
    private string playerBio = "Enter Bio";
    private bool isMale = true;
    private int genderSelection;
    private string[] gender = new string[2]{"Male","Female"};

    public void DisplayClassSelections()
    {
        //list of toggle buttons each button will be different class
        //selection grid
        classSelection = GUI.SelectionGrid(new Rect(50,50,250,300), classSelection, classSelectionNames, 2);
        GUI.Label(new Rect(450,50,300,300),FindClassDescription(classSelection) );
        GUI.Label(new Rect(450, 100, 300, 300), FindClassStatValues(classSelection));
        
    }

    private string FindClassDescription(int classSelection)
    {
        if (classSelection == 0)
        {
            BaseCharacterClass tempClass = new BaseMageClass();
            return tempClass.CharacterClassDescription;
        }
        else if (classSelection == 1)
        {
            BaseCharacterClass tempClass = new BaseWarriorClass();
            return tempClass.CharacterClassDescription;
        }
        return "NO CLASS FOUND";
    }
    private string FindClassStatValues(int classSelection)
    {
        if (classSelection == 0)
        {
            BaseCharacterClass tempClass = new BaseMageClass();
            string tempStats = "Stamina: "+ tempClass.Stamina + "\n"+
                               "Endurance: "+ tempClass.Endurance + "\n"+
                               "Intellect: "+ tempClass.Intellect + "\n"+
                               "Strength: "+ tempClass.Strength + "\n"+
                               "Agility: "+ tempClass.Agility + "\n"+
                               "Resistance: "+ tempClass.Resistance + "\n";
            return tempStats;
        }
        else if (classSelection == 1)
        {
            BaseCharacterClass tempClass = new BaseWarriorClass();
            string tempStats = "Stamina: " + tempClass.Stamina + "\n" +
                               "Endurance: " + tempClass.Endurance + "\n" +
                               "Intellect: " + tempClass.Intellect + "\n" +
                               "Strength: " + tempClass.Strength + "\n" +
                               "Agility: " + tempClass.Agility + "\n" +
                               "Resistance: " + tempClass.Resistance + "\n";
            return tempStats;
        }
        return "NO CLASS FOUND";
    }
    public void DisplayStatAllocation()
    {
        //list of stats with plus and minus to add stats
        //logic to make sure player can not add more stats than given
        statAllocationModule.DisplayStatAllocationModule();
    }
    public void DisplayFinalSetup()
    {
        //name
        playerFirstName = GUI.TextArea(new Rect(20, 10, 150, 25), playerFirstName, 25);
        playerLastName = GUI.TextArea(new Rect(20, 55, 150, 25), playerLastName, 25);
        
        //gender
        //isMale = GUI.Toggle(new Rect(0, 0, 0, 0), isMale, "Male");
        //isMale = GUI.Toggle(new Rect(0, 0, 0, 0), isFemale, "Female");
        genderSelection = GUI.SelectionGrid(new Rect(200, 10, 75, 75), genderSelection, gender,1);
        //add a description bio to character
        playerBio = GUI.TextArea(new Rect(20, 90, 250, 200), playerBio, 255);
    }

    private void ChooseClass(int classSelection)
    {
        if (classSelection == 0)
        {
            GameInformation.PlayerClass = new BaseMageClass();
        }
        else if (classSelection == 1)
        {
            GameInformation.PlayerClass = new BaseWarriorClass();
        }
    }
    public void DisplayMainItems()
    {
        Transform player = GameObject.FindGameObjectWithTag("Player").transform;
        GUI.Label(new Rect(Screen.width/2, 20, 250, 250), "CREATE NEW PLAYER");
        if (GUI.Button(new Rect(350, 350, 50, 50), "<<<"))
        {
            //turn transform tagged as player to the left
            player.Rotate(Vector3.up * 10);
        }
        if (GUI.Button(new Rect(450, 350, 50, 50), ">>>"))
        {
            //turn transform tagged as player to the right
            player.Rotate(Vector3.down * 10);
        }
        if (CreatePlayerGui.currentState != CreatePlayerGui.CreateAPlayerStates.FINALSETUP)
        {
            if (GUI.Button(new Rect(500, 350, 50, 50), "Next"))
            {
                if (CreatePlayerGui.currentState == CreatePlayerGui.CreateAPlayerStates.CLASSSELECTION)
                {
                    ChooseClass(classSelection);
                    CreatePlayerGui.currentState = CreatePlayerGui.CreateAPlayerStates.STATALLOCATION;
                }
                else if (CreatePlayerGui.currentState == CreatePlayerGui.CreateAPlayerStates.STATALLOCATION)
                {
                    GameInformation.Stamina = statAllocationModule.pointsToAllocate[0];
                    GameInformation.Endurance = statAllocationModule.pointsToAllocate[1];
                    GameInformation.Intellect = statAllocationModule.pointsToAllocate[2];
                    GameInformation.Strength = statAllocationModule.pointsToAllocate[3];
                    GameInformation.Agility = statAllocationModule.pointsToAllocate[4];
                    GameInformation.Resistance= statAllocationModule.pointsToAllocate[5]; 
                    CreatePlayerGui.currentState = CreatePlayerGui.CreateAPlayerStates.FINALSETUP;
                }
            }
        }
        else if (CreatePlayerGui.currentState == CreatePlayerGui.CreateAPlayerStates.FINALSETUP)
        {
            if (GUI.Button(new Rect(500, 350, 50, 50), "Finish"))
            {
                //final save
                GameInformation.PlayerName = playerFirstName + " " + playerLastName;
                GameInformation.PlayerBio = playerBio;
                if (genderSelection == 0)
                {
                    GameInformation.IsMale = true;
                }
                else if (genderSelection == 1)
                {
                    GameInformation.IsMale = false;
                }
                SaveInformation.SaveAllInformation();
               
            }
        }
        if (CreatePlayerGui.currentState != CreatePlayerGui.CreateAPlayerStates.CLASSSELECTION)
        {
            if (GUI.Button(new Rect(300, 350, 50, 50), "Back"))
            {
                if (CreatePlayerGui.currentState == CreatePlayerGui.CreateAPlayerStates.STATALLOCATION)
                {
                    statAllocationModule.didRunOnce = false;
                    

                    GameInformation.PlayerClass = null;
                    
                    CreatePlayerGui.currentState = CreatePlayerGui.CreateAPlayerStates.CLASSSELECTION;
                }
                else if (CreatePlayerGui.currentState == CreatePlayerGui.CreateAPlayerStates.FINALSETUP)
                {
                    CreatePlayerGui.currentState = CreatePlayerGui.CreateAPlayerStates.STATALLOCATION;
                }
            }
        }

    }
}
