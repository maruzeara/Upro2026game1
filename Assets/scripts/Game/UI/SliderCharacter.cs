using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderCharacter : MonoBehaviour
{
    private Slider _slider;

    void Start()
    {
        _slider = GetComponent<Slider>();

        _slider.maxValue = EventBus.FOnGetHPCharacter.Invoke(0);
        _slider.value = EventBus.FOnGetHPCharacter.Invoke(0);

    }

     void Update()
    {
        _slider.value = EventBus.FOnGetHPCharacter.Invoke(0);
    }

}
