using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class ColorPicker : GUIcategory
{
    public Image color_preview;
    public Slider r_slider;
    public TextMeshProUGUI r_slider_textmeshpro;
    public Slider g_slider;
    public TextMeshProUGUI g_slider_textmeshpro;
    public Slider b_slider;
    public TextMeshProUGUI b_slider_textmeshpro;
    public Material material;
    
    
   
    // Start is called before the first frame update
    void Start()
    {
        r_slider.value = material.color.r;
        g_slider.value = material.color.g;
        b_slider.value = material.color.b;
    }

    // Update is called once per frame
    void Update()
    {
        color_preview.color = material.color = new Color(r_slider.value, g_slider.value, b_slider.value);
        r_slider_textmeshpro.text = r_slider.value.ToString("F2");
        g_slider_textmeshpro.text = g_slider.value.ToString("F2");
        b_slider_textmeshpro.text = b_slider.value.ToString("F2");
        
    }

}
