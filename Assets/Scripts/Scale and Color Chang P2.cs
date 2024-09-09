using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Slider _slider_altura;
    public Slider _slider_color;

    private float altura_valor;
    private float color_valor;
    

    //private SpriteRenderer spriteRenderer;

    //private void Awake()
    //{
    //    spriteRenderer = GetComponent<SpriteRenderer>();
    //}
    void Update()
    {
        altura_valor = _slider_altura.value;
        Vector3 scale = new Vector3(0.91f, altura_valor, 0.91f);
        this.transform.localScale = scale;



        //color_valor = _slider_color.value;
        //this.spriteRenderer.color = new Color(color_valor, color_valor, color_valor );

    }
   
}
