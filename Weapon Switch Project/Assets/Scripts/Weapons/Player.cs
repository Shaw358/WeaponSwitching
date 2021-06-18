using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] WeaponSwitcher switchWeapon;

    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            switchWeapon.NextWeapon();
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            switchWeapon.PreviousWeapon();
        }
    }
}