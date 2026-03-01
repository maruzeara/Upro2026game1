using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpeed : MonoBehaviour, ibonus
{
    public void Use()
    {
        EventBus.AOnSpeedCharacter.Invoke(0);
        ObjectsPool.Instance.ReturnObject(this);
    }
}
