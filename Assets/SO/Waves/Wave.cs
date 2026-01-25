using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "info", menuName = "Info/Wave")]

public class Wave : ScriptableObject
{
    [SerializeField]
    private float _duration;
    [SerializeField]
    private float _timeBeetwenSpawn;
    [SerializeField]
    private List<EnemySO> enemies;

    public float Duration { get => _duration; }
    public float TimeBeetwenSpawn { get => _timeBeetwenSpawn; }
    public List<EnemySO> Enemies { get => enemies; }
}
