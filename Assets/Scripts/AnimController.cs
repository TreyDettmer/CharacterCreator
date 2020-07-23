using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    Animator anim;
    FaceController faceController;
    public CameraController cameraController;
    public GameObject[] guitars;
    public int currentGuitarIndex = 0;

    private void Start()
    {
        anim = GetComponent<Animator>();
        faceController = GetComponent<FaceController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            
            if (anim.GetInteger("condition") == 0)
            {
                StartCoroutine(IdleAnimRoutine(1,6.208f));
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (anim.GetInteger("condition") == 0)
            {
                StartCoroutine(IdleAnimRoutine(2,4.598f));
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (anim.GetInteger("condition") == 0)
            {
                StartCoroutine(IdleAnimRoutine(3,2.458f));
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (anim.GetInteger("condition") == 0)
            {
                StartCoroutine(IdleAnimRoutine(4,3.625f));
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (anim.GetInteger("condition") == 0)
            {
                StartCoroutine(IdleAnimRoutine(5, 4.167f));
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            cameraController.FocusCamera(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            cameraController.FocusCamera(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            cameraController.FocusCamera(1);
        }


    }

    /// <param name="condition">Index of animation to play.</param>
    /// <param name="time">The length of the animation.</param>
    IEnumerator IdleAnimRoutine(int condition,float time = 5f)
    {
        faceController.RunAnimation(condition);
        anim.SetInteger("condition", condition);
        yield return new WaitForSeconds(time);
        anim.SetInteger("condition", 0);
        faceController.RunAnimation(0);

    }

    public void DrawGuitar()
    {
        if (anim)
        {
            if (anim.GetInteger("condition") < 6) //if we're not already holding the guitar
            {
                StartCoroutine("DrawGuitarRoutine");
            }
        }
    }

    public void StoreGuitar()
    {
        if (anim)
        {
            if (anim.GetInteger("condition") >= 6)
            {
                StartCoroutine("StoreGuitarRoutine");
            }
        }
    }

    IEnumerator DrawGuitarRoutine()
    {
        anim.SetInteger("condition", 6);
        yield return new WaitForSeconds(0.625f);
        for (int i = 0; i < guitars.Length;i++)
        {
            if (i == currentGuitarIndex)
            {
                guitars[i].SetActive(true);
            }
            else
            {
                guitars[i].SetActive(false);
            }
        }
        anim.SetInteger("condition", 7);

    }
    IEnumerator StoreGuitarRoutine()
    {
        for (int i = 0; i < guitars.Length; i++)
        {
            if (guitars[i].activeSelf)
            {
                currentGuitarIndex = i;
            }
        }
        anim.SetInteger("condition", 8);
        foreach (GameObject guitar in guitars)
        {
            guitar.SetActive(false);
        }
        yield return new WaitForSeconds(0.625f);
        anim.SetInteger("condition", 0);
        foreach (GameObject guitar in guitars) //ensures guitar is not shown
        {
            guitar.SetActive(false);
        }
    }
}
