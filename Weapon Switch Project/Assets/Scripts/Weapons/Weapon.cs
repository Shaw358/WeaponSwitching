using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WeaponEnums;

[CreateAssetMenu(fileName = "NewWeapon", menuName = "Weapon")]
public class Weapon : ScriptableObject
{
    public string name;
    public int dps;

    public WeaponEnum weaponType;
}