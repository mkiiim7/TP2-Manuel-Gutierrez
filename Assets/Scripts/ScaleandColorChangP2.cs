using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleandColorChangP2 : MonoBehaviour
{
    public Slider sliderAltura;
    public Slider sliderColorRed;

    private float alturaValor;
    private float colorValor;
    

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        sliderAltura.onValueChanged.AddListener(OnAlturaChange);
        sliderColorRed.onValueChanged.AddListener(OnColorRedChange);
    }

    private void OnColorRedChange(float arg0)
    {
        Color color = spriteRenderer.color;
        color.r = arg0;
        this.spriteRenderer.color = color;

    }

    private void OnAlturaChange(float arg0)
    {
        alturaValor = arg0;
        Vector3 scale = new Vector3(0.91f, alturaValor, 0.91f);
        this.transform.localScale = scale;

       
    }

   
   
}
