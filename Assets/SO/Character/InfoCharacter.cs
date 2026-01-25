using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "info", menuName = "Info/Info Character")]

public class InfoCharacter : ScriptableObject
{
    [SerializeField]
    private Sprite _character;
    [SerializeField]
    private Sprite _baseWeapon;
    [SerializeField]
    private string _description;
    [SerializeField]
    private InfoWeapon _prefabWeapon;
    [SerializeField]
    private float _maxHP;

    public Sprite Character { get => _character; }
    public Sprite BaseWeapon { get => _baseWeapon; }
    public string Description { get => _description; }
    public InfoWeapon PrefabWeapon { get => _prefabWeapon; }
    public float MaxHP { get => _maxHP;}
} 

