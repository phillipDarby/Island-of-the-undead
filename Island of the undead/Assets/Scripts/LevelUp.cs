using UnityEngine;
using System.Collections;

public class LevelUp
{
    public int maxPlayerLevel = 50;
    public void LevelUpCharacter()
    {
        //check to see if current xp is > required xp
        if (GameInformation.CurrentXP > GameInformation.RequiredXP)
        {
            GameInformation.CurrentXP -= GameInformation.RequiredXP;
        }
        else
        {
            GameInformation.CurrentXP = 0;
        }
        if (GameInformation.PlayerLevel < maxPlayerLevel)
        {
            GameInformation.PlayerLevel += 1;
        }
        else
        {
            GameInformation.PlayerLevel = maxPlayerLevel;
        }

        //give stat points
        //random items
        //give move/ability
        //give money
        //determine next amount of requied xp
        DetermineXpForNextLevel(GameInformation.PlayerLevel);
    }

    

    private void DetermineMoneyToGive()
    {
        if (GameInformation.PlayerLevel <= 10)
        {
            //give a certain amount of money
        }
    }

    private int DetermineXpForNextLevel(int playerLevel)
    {
        playerLevel += 1;
        int levels = 50;
        float xpLevel1 = 500.0f;
        float xpLevel50 = 400000.0f;
        float temp1 = Mathf.Log(xpLevel50/xpLevel1);
        float b = temp1/(levels - 1);
        float temp2 = (Mathf.Exp(b) - 1);
        float a = (xpLevel1)/temp2;
        int oldxp = (int) (a*Mathf.Exp((float) b*(playerLevel - 1)));
        int newxp = (int)(a * Mathf.Exp((float)b * playerLevel ));
        int temp = newxp - oldxp;
        temp = (int) Mathf.Round((float) temp/10.0f)*10;
        return temp;
    }
}
