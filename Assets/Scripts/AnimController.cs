using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
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
    }

    /// <param name="condition">Index of animation to play.</param>
    /// <param name="time">The length of the animation.</param>
    IEnumerator IdleAnimRoutine(int condition,float time = 5f)
    {
        anim.SetInteger("condition", condition);
        yield return new WaitForSeconds(time);
        anim.SetInteger("condition", 0);
        
    }
}
