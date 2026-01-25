using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "infoWeapon", menuName = "Info/Weapon")]


public class InfoWeapon : ScriptableObject
{
    [SerializeField]
    private TypeWeapon _typeWeapon;
    [SerializeField]
    private Sprite _weapon;
    [SerializeField]
    private float _damage;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _spawnSec;
    [SerializeField]
    private float _despawnSec;

    public TypeWeapon TypeWeapon { get => _typeWeapon; }
    public Sprite Weapon { get => _weapon;}
    public float Damage { get => _damage;}
    public float Speed { get => _speed;}
    public float SpawnSec { get => _spawnSec;}
    public float DespawnSec { get => _despawnSec;}
}
 public enum TypeWeapon
    {
        Sword,
        Book,
        Hammer
    }