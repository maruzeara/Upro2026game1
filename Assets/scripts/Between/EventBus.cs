using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventBus : MonoBehaviour
{
    public static Action<PanelDiscription> OnInfoCaracter;
    public static Action<InfoWeapon> OnAddWeapon;
    public static Action<GameObject> OnWeaponsDes;

    public static Action<float> AOnsubHPCharacter;
    public static Func<byte,float> FOnGetHPCharacter;

    public static Action<float> AOnSpeedCharacter;
    public static Action<float> AOnAddTimeDurationWeapon;
    public static Action<float> AOnAddTimeSpeedWeapon;
    public static Action<float> AOnAddTimeCreateEnemies;
    public static Action<float> AOnAddHPCharacter;

    public static Func<byte, Vector2> Oncontroll;
    public static Func<byte, Vector3> OnPositionCharacter;

    public static Func<byte, float> FOnSpeedCharacter;
    public static Func<byte, float> FOnAddTimeDurationWeapon;
    public static Func<byte, float> FOnAddTimeSpeedWeapon;
    public static Func<byte, float> FOnAddTimeCreateEnemies;
}
