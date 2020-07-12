using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GUIfeature : GUIcategory
{
    Image background;
    public Material linkedMaterial;
    public float offset;
    public GameObject[] linkedGameObject;
    public GameObject[] objectsToDisable;
    public Color color;
    public Texture texture;

    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApplyFeature()
    {
        if (linkedMaterial != null)
        {
            if (offset > -1)
            {
                linkedMaterial.SetTextureOffset("_MainTex", new Vector2(offset, 0));
            }
            else if (offset  == -1)
            {
                linkedMaterial.color = color;
            }
            else if (texture != null)
            {
                linkedMaterial.SetTexture("_MainTex", texture);
            }
        }
        else if (linkedGameObject.Length > 0)
        {
            foreach (GameObject objectToDisable in objectsToDisable)
            {
                objectToDisable.SetActive(false);
            }
            foreach (GameObject obj in linkedGameObject)
            {
                obj.SetActive(true);
            }
        }
        else if (objectsToDisable.Length > 0)
        {
            foreach (GameObject objectToDisable in objectsToDisable)
            {
                objectToDisable.SetActive(false);
            }
        }
    }
    public void DisableFeature()
    {
        //if (linkedMaterial != null)
        //{
        //    linkedMaterial.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        //}
        if (linkedGameObject.Length > 0)
        {
            foreach (GameObject obj in linkedGameObject)
            {
                obj.SetActive(false);
            }
           
        }
    }

    public void OnPointerClick()
    {
        ApplyFeature();
    }
    public void OnPointerEnter()
    {
        background.color = new Color(.6f, .6f, .6f, .39f);

    }
    public void OnPointerExit()
    {
        background.color = new Color(1, 1, 1, .39f);


    }
}
