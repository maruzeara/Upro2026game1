using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectPanelDiscription : MonoBehaviour
{
    public void Init()
    {
        EventBus.OnInfoCaracter += SetImageAndText;
    }

    private void OnDestroy()
    {
        EventBus.OnInfoCaracter -= SetImageAndText;
    }

    private void SetImageAndText(PanelDiscription discription)
    {
        transform.GetChild(0).GetComponent<Image>().sprite = discription.info.Character;
        transform.GetChild(1).GetComponent<Localize>().LocalizationKey = discription.info.Description;
        transform.GetChild(1).GetComponent<Localize>().UpdateLocale();
    }
}
