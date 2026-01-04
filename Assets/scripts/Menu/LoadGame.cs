using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour
{
    [SerializeField] private GameObject _panelMenu;
    [SerializeField] private GameObject _panelLoad;
    [SerializeField] private Slider _loadSlider;
    [SerializeField] private Button _button;

    void Start()
    {
        _button.onClick.AddListener(() =>
        {
            StartCoroutine(LoadScene());

            _panelLoad.SetActive(true);
            _panelMenu.SetActive(false);

        });
    }

    private IEnumerator LoadScene()
    {
        StartCoroutine(Load.Instance.LoadScene(2));
        while (Load.Instance._Load < 0.9f)
        {
            _loadSlider.value = Load.Instance._Load;
            yield return null;

        }
        _loadSlider.value = 1f;
    }


}
