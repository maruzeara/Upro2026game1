using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private InfoWeapon _infoWeapon;

    public InfoWeapon InfoWeapon { get => _infoWeapon; set => _infoWeapon = value; }

    public void Init()
    {
        
    }
}
