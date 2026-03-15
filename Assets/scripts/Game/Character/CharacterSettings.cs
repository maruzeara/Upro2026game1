using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSettings : MonoBehaviour
{
    private float _speedCharacter = 10;
    private float _addTimeDurationWeapon = 0;
    private float _addTimeSpeedWeapon = 1;
    private float _addTimeCreateEnemis = 0;
    private float _addHPCharacter = 20;

    private float _hp;

    public void Init(float HP)
    {
        EventBus.FOnSpeedCharacter += GetSpeed;
        EventBus.FOnAddTimeDurationWeapon += GetTDW;
        EventBus.FOnAddTimeSpeedWeapon += GetTSW;
        EventBus.FOnAddTimeCreateEnemies += GetTCE;
        EventBus.AOnAddHPCharacter += HPCharacter;

        EventBus.AOnSpeedCharacter += AddSpeed;
        EventBus.AOnAddTimeDurationWeapon += AddTDW;
        EventBus.AOnAddTimeSpeedWeapon += AddTSW;
        EventBus.AOnAddTimeCreateEnemies += AddTCE;

        EventBus.AOnsubHPCharacter += SetHP;
        EventBus.FOnGetHPCharacter += GetHP;

        _hp = HP;
    }

    private void HPCharacter(float obj)
    {
        _addHPCharacter += obj;
    }

    private void AddTSW(float obj)
    {
        _addTimeSpeedWeapon += 2f;
    }

    

    private float GetTSW(byte arg)
    {
        return _addTimeSpeedWeapon;
    }

    private void AddTCE(float obj)
    {
        _addTimeCreateEnemis += 0.7f;
    }

    private void AddTDW(float obj)
    {
        _addTimeDurationWeapon += 1f;
    }

    private void AddSpeed(float obj)
    {
        _speedCharacter += 5f;
    }

    private float GetHP(byte arg)
    {
        return _hp;
    }

    private void SetHP(float damage)
    {
        _hp -= damage;

        if (_hp <= 0)
            StartCoroutine(LoadScene());
    }

    private IEnumerator LoadScene()
    {
        yield return Load.Instance.LoadScene(1);
    }


    private float GetTCE(byte arg)
    {
        return _addTimeCreateEnemis;
    }

    private float GetTDW(byte arg)
    {
        return _addTimeDurationWeapon;
    }

    private float GetSpeed(byte arg)
    {
        return _speedCharacter;
    }
    private void OnDestroy()
    {
        EventBus.FOnSpeedCharacter -= GetSpeed;
        EventBus.FOnAddTimeDurationWeapon -= GetTDW;
        EventBus.FOnAddTimeSpeedWeapon -= GetTSW;
        EventBus.FOnAddTimeCreateEnemies -= GetTCE;
        EventBus.AOnAddHPCharacter -= HPCharacter;

        EventBus.AOnSpeedCharacter -= AddSpeed;
        EventBus.AOnAddTimeDurationWeapon -= AddTDW;
        EventBus.AOnAddTimeSpeedWeapon -= AddTSW;
        EventBus.AOnAddTimeCreateEnemies -= AddTCE;
        

        EventBus.AOnsubHPCharacter -= SetHP;
        EventBus.FOnGetHPCharacter -= GetHP;
    }
}
