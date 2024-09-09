using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Slider_Value_Text : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _slider_Text;


    void Start()
    {
        _slider.onValueChanged.AddListener((v) =>
            {
                _slider_Text.text = v.ToString("0.00");
            });
    }

   
    void Update()
    {
        
    }
}
