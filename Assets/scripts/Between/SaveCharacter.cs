using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveCharacter : singleton<SaveCharacter>
{
    [SerializeField]
    InfoCharacter _currentCharacter;

    public InfoCharacter CurrentCharacter { get => _currentCharacter; }

    public void Init()
    {
        EventBus.OnInfoCaracter += SetCurrentCharacter;
    }

    private void SetCurrentCharacter(PanelDiscription panel)
    {
        _currentCharacter = panel.info;
    }

    public override void OnDestroy()
    {
        base.OnDestroy();
        EventBus.OnInfoCaracter -= SetCurrentCharacter;
    }
}
