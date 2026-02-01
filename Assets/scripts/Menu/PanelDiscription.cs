using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PanelDiscription : MonoBehaviour
{
    InfoCharacter _info;

    public InfoCharacter info { get => _info; }

    private void OnDestroy()
    {
        EventBus.OnInfoCaracter -= SetBackground;
    }
    public void Spawn(InfoCharacter character)
    {
        _info = character;

        transform.GetChild(0).GetComponent<Image>().sprite = _info.Character;
        transform.GetChild(1).GetComponent<Localize>().LocalizationKey = _info.Description;
        transform.GetChild(2).GetComponent<Image>().sprite = _info.BaseWeapon;

        GetComponent<Button>().onClick.AddListener(() =>
        {
            EventBus.OnInfoCaracter?.Invoke(this);
        });

        GetComponent<RectTransform>().localScale = Vector3.one;
        GetComponent<RectTransform>().position = new Vector3(transform.position.x, transform.position.y, 0);
        EventBus.OnInfoCaracter += SetBackground;
    }

    private void SetBackground(PanelDiscription panel)
    {
        if (panel == this)
            transform.GetComponent<Image>().color = new Color(0.490566f, 0.4792552f, 0.4785333f, 0.3843137f);
        else
            transform.GetComponent<Image>().color = new Color(0.7830189f, 0.04590829f,0, 0.3843137f);
    }
   
}
