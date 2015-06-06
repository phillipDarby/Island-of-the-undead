using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BattleGui : MonoBehaviour
{
    private Text playersName;
    public GameObject PlayerNameBG;
    private Text playerHealth;
    public GameObject PlayerHealth;
    private Image playerHealthImage;
    public GameObject HealthBar;
    private string playername = "Gandoff";
    //private string playerName;
    private int playerLevel;
    //private int playerHealth;
    private int playerEnergy;

	// Use this for initialization
	void Start ()
	{
	    GameInformation.PlayerName = "Gandoff";
	    GameInformation.Stamina = 20;
        playersName = PlayerNameBG.GetComponentInChildren<Text>();
        playerHealth = PlayerHealth.GetComponentInChildren<Text>();
	    playerHealthImage = HealthBar.GetComponent<Image>();
        playersName.text = GameInformation.PlayerName;
	    playerHealth.text = GameInformation.Stamina.ToString();
	    playerHealthImage.fillAmount = GameInformation.Stamina/50.0f;

	    //playerLevel = GameInformation.PlayerLevel;
	}
	
	// Update is called once per frame
	void Update () {
       // playerName.text = playername;
	}
}
