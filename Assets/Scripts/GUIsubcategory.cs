using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GUIsubcategory : GUIcategory
{
    Image background;
    public GUIsubcategory[] otherSubCategories;
    private void Start()
    {
        background = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerEnter()
    {
        background.color = new Color(.6f, .6f, .6f, .39f);

    }
    public void OnPointerExit()
    {
        background.color = new Color(1, 1, 1, .39f);


    }

    public void OnPointerClick()
    {
        foreach (GUIsubcategory subCategory in otherSubCategories)
        {
            subCategory.HideSubCategories();
        }
        foreach (GUIcategory child in children)
        {
            child.ShowCategory();
        }
    }
    public void HideSubCategories()
    {
        foreach (GUIcategory child in children)
        {
            child.HideCategory();
        }
    }
}
