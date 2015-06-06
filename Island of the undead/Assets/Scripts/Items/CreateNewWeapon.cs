
using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour
{

    private BaseWeapon newWeapon;


    void Start()
    {
        CreateWeapon();
        Debug.Log(newWeapon.ItemName);
        Debug.Log(newWeapon.ItemDescription);
        Debug.Log(newWeapon.ItemID.ToString());
        Debug.Log(newWeapon.WeaponType.ToString());
        Debug.Log(newWeapon.Stamina.ToString());
        Debug.Log(newWeapon.Endurance.ToString());
    }

    public void CreateWeapon()
    {
        newWeapon = new BaseWeapon();


        //assign name to weapon
        newWeapon.ItemName = "W" + Random.Range(1, 101);
        //create a weapon description
        newWeapon.ItemDescription = "This is a new Weapon.";
        //weapon id
        newWeapon.ItemID = Random.Range(1, 101);
        //stats
        newWeapon.Stamina = Random.Range(1, 11);
        newWeapon.Endurance = Random.Range(1, 11);
        newWeapon.Intellect = Random.Range(1, 11);
        newWeapon.Strength = Random.Range(1, 11);
        //choose type of weapon
        ChooseWeaponType();
        //spell effect id
        newWeapon.SpellEffectID = Random.Range(1, 101);
    }

    private void ChooseWeaponType()
    {
        int randomTemp = Random.Range(1, 7);
        switch (randomTemp)
        {
            case 1:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
                break;
            case 2:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
                break;
            case 3:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
                break;
            case 4:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
                break;
            case 5:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD;
                break;
            case 6:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.POLEARM;
                break;
        }
        
    }
}
