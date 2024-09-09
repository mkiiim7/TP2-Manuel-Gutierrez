using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleandColorChangP1 : MonoBehaviour
{
    public Slider _slider_altura;
    public Slider _slider_color;

    private float altura_valor;
    private float color_valor;

    void Update()
    {
        altura_valor = _slider_altura.value;
        Vector3 scale = new Vector3(1.29f, altura_valor, 1.29f);
        this.transform.localScale = scale;

        //color_valor1 = _slider_color.value;
        //this.spriteRenderer.color = new Color(color_valor, color_valor, color_valor );

    }
}
