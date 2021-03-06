﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GUIcategory : MonoBehaviour
{
    public GUIcategory[] children;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideCategory()
    {
        foreach (GUIcategory child in children)
        {
            child.HideCategory();
        }
        this.gameObject.SetActive(false);
        for (int a = 0; a < transform.childCount; a++)
        {
            transform.GetChild(a).gameObject.SetActive(false);
        }
    }

    public virtual void ShowCategory()
    {
        this.gameObject.SetActive(true);
        for (int a = 0; a < transform.childCount; a++)
        {
            transform.GetChild(a).gameObject.SetActive(true);
        }
    }
}
