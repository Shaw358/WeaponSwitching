using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    //assuming this is an object pool you either instantiate or enable the weapon, I will use object pooling as it's less demanding on the system short term
    //NOTE: this does not use animations
    //TODO: Implement weapons switch animations - use an IEnumerator

    [SerializeField] List<Weapon> weapons = new List<Weapon>();
    [SerializeField] List<GameObject> weaponGameobjects = new List<GameObject>();

    [SerializeField] TextHandler weaponNameFeedback;

    private int weaponIndex;

    private void Awake()
    {
        weaponIndex = 0;
    }

    private void Start()
    {
        GoToWeapon(0);
    }

    public void NextWeapon()
    {
        DisableWeapon();
        if(weaponIndex < weapons.Count - 1)
        {
            weaponIndex++;
        }
        else
        {
            weaponIndex = 0;
        }
        EnableWeapon();
    }

    public void PreviousWeapon()
    {
        DisableWeapon();
        if (weaponIndex > 0)
        {
            weaponIndex--;
        }
        else
        {
            weaponIndex = weapons.Count - 1;
        }
        EnableWeapon();
    }

    public void GoToWeapon(int index)
    {
        DisableWeapon();
        weaponIndex = index;
        EnableWeapon();
    }

    private void EnableWeapon()
    {
        weaponGameobjects[weaponIndex].SetActive(true);
        weaponNameFeedback.SetText(weapons[weaponIndex].name);
    }

    private void DisableWeapon()
    {
        weaponGameobjects[weaponIndex].SetActive(false);
    }

    //Potential animation stuff?
    private IEnumerator WaitForAnimationFinished()
    {
        yield return new WaitForSeconds(0);
    }
}