using System.Collections.Generic;
using UnityEngine;

public class CreatePanelDiscription : MonoBehaviour
{
    [SerializeField]
    private PanelDiscription _prefabPanel;
    [SerializeField]
    private Transform _parent;

    public void Create(List<InfoCharacter> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            PanelDiscription obj = ObjectsPool.Instance.GetObject(_prefabPanel).GetComponent<PanelDiscription>();

            obj.transform.parent = _parent;
            obj.Spawn(list[i]);

            if (i == 0) EventBus.OnInfoCaracter?.Invoke(obj);
        }
    }
}


//‎שךונוו

