using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIpanel : GUIcategory
{

    public override void ShowCategory()
    {
        base.ShowCategory();
        foreach (GUIcategory child in children)
        {
            child.ShowCategory();
        }
    }

}
