using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointGame : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefabCharacter;
    [SerializeField]
    private CameraMove _camera;

     void Start()
    {
        GameObject chaarcter = Instantiate(_prefabCharacter, Vector3.zero, Quaternion.identity);
        chaarcter.GetComponent<CharacterInit>().Init();

        _camera.Init(chaarcter.transform);
    }
}
