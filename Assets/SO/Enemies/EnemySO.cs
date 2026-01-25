using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "info", menuName = "Info/Enemy")]
public class EnemySO : ScriptableObject
{
    [SerializeField]
    private float _maxHP;
    [SerializeField]
    private float _damage;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private Sprite _spriteEnemy;

    public float MaxHP { get => _maxHP;}
    public float Damage { get => _damage;}
    public float Speed { get => _speed;}
    public Sprite SpriteEnemy { get => _spriteEnemy;}
}
