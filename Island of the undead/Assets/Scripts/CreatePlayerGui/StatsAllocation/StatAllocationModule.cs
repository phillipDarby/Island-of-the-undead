using UnityEngine;
using System.Collections;
using UnityEditor;

public class StatAllocationModule
{

    private string[] statName = new string[6] { "Stamina", "Endurance", "Intellect", "Strength", "Agility", "Resistance"};
    private string[] statDescriptions = new string[6] { "Health Modifier", "Energy Modifier", "Magical Damage Modifier", "Physical Damage Modifier", "Haste and Critical Strike Modifier", "All Damage Reduction Modifier"};
    private bool[] statSelections = new bool[6];

    public int[] pointsToAllocate = new int[6];//starting stat values for chosen class, 
    private int[] baseStatPoints = new int[6];//starting stat values for chosen class
    private int availPoints = 5;
    public bool didRunOnce = false;

    public void DisplayStatAllocationModule()
    {
        if (!didRunOnce)
        {
            RetrieveBaseStatPoints();
            didRunOnce = true;
        }
        
        DisplayStatToggleSwitches();
        DisplayStatIncreaseDecreaseButtons();
    }

    private void DisplayStatToggleSwitches()
    {
        for (int i = 0; i < statName.Length; i++)
        {
            statSelections[i] = GUI.Toggle(new Rect(10, 60*i + 10, 100, 50), statSelections[i], statName[i]);
            GUI.Label(new Rect(100,60*i + 10,50,50), pointsToAllocate[i].ToString());
            if (statSelections[i])
            {
                GUI.Label(new Rect(20,60*i + 30,150,100),statDescriptions[i] );
            }
        }
    }


    private void DisplayStatIncreaseDecreaseButtons()
    {
        for (int i = 0; i < pointsToAllocate.Length; i++)
        {
            if (pointsToAllocate[i] >= baseStatPoints[i] && availPoints > 0)
            {
                if (GUI.Button(new Rect(200, 60*i + 10, 50, 50), "+"))
                {
                    pointsToAllocate[i] += 1;
                    --availPoints;
                }
            }
            if (pointsToAllocate[i] > baseStatPoints[i] )
            {
                if (GUI.Button(new Rect(260, 60*i + 10, 50, 50), "-"))
                {
                    pointsToAllocate[i] -= 1;
                    ++availPoints;
                }
            }
        }
    }

    private void RetrieveBaseStatPoints()
    {
        BaseCharacterClass cclass = GameInformation.PlayerClass;
        pointsToAllocate[0] = cclass.Stamina;
        baseStatPoints[0] = cclass.Stamina;
        pointsToAllocate[1] = cclass.Endurance;
        baseStatPoints[1] = cclass.Endurance;
        pointsToAllocate[2] = cclass.Intellect;
        baseStatPoints[2] = cclass.Intellect;
        pointsToAllocate[3] = cclass.Strength;
        baseStatPoints[3] = cclass.Strength;
        pointsToAllocate[4] = cclass.Agility;
        baseStatPoints[4] = cclass.Agility;
        pointsToAllocate[5] = cclass.Resistance;
        baseStatPoints[5] = cclass.Resistance;

    }
}
