using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointGame : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefabCharacter;
    [SerializeField]
    private CameraMove _camera;
    [SerializeField]
    private Weapon _prefadWeapon;
    [SerializeField]
    private WeaponManager _weaponManager;
     void Start()
    {
        GameObject character = Instantiate(_prefabCharacter, Vector3.zero, Quaternion.identity);
        character.GetComponent<CharacterInit>().Init();

        _camera.Init(character.transform);

        ObjectsPool.Instance.AddObjects(_prefadWeapon, 10);

        _weaponManager.Init(character);
        EventBus.OnAddWeapon?.Invoke(SaveCharacter.Instance.CurrentCharacter.PrefabWeapon);

        GetComponent<ControllWaves>().StartWaves();
    }
}
      