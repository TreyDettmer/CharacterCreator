using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BodyCategory : GUIcategory
{
    Image background;
    public BodyCategory[] otherBodyCategories;
    public AnimController animController;

    private void Start()
    {
        background = GetComponent<Image>();
        foreach (BodyCategory bodyCategory in otherBodyCategories)
        {
            bodyCategory.HideSubCategories();
        }
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
        foreach (BodyCategory bodyCategory in otherBodyCategories)
        {
            bodyCategory.HideSubCategories();
        }
        foreach (GUIcategory child in children)
        {
            child.ShowCategory();
        }

        if (animController)
        {
            animController.DrawGuitar(0);
        }
        
        
    }

    public void HideSubCategories()
    {
        foreach (GUIcategory child in children)
        {
            child.HideCategory();
        }
        if (animController)
        {
            animController.StoreGuitar();
        }
    }


}
