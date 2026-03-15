using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusHP :MonoBehaviour, ibonus
{
    public void Use()
    {
        EventBus.AOnAddHPCharacter.Invoke(20);
        ObjectsPool.Instance.ReturnObject(this);
    }
}
