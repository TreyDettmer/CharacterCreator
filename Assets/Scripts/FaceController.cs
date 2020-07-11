using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceController : MonoBehaviour
{

    enum Animation : byte
    {
        BasicIdle = 0,
        IdleButt = 1,
        IdleCheckoutArms = 2,
        IdleCheckoutBack = 3,
        IdleCheckoutLegs = 4,
        IdleTwist = 5
    }
    public Material mat_mouth;
    public Material mat_eyes;
    public Material mat_eyebrows;
    private bool bBaseIdleRoutine = false;
    

    private void Start()
    {
        StartCoroutine("BasicIdleRoutine");
    }

    public void RunAnimation(int animation)
    {
        if (animation != (byte)Animation.BasicIdle)
        {
            if (bBaseIdleRoutine)
            {
                bBaseIdleRoutine = false;
                StopCoroutine("BasicIdleRoutine");
                
            }
            switch (animation)
            {
                case (byte)Animation.IdleButt:
                    StartCoroutine("IdleButtRoutine");
                    break;
                case (byte)Animation.IdleCheckoutArms:
                    StartCoroutine("IdleCheckoutArmsRoutine");
                    break;
                case (byte)Animation.IdleCheckoutBack:
                    StartCoroutine("IdleCheckoutBackRoutine");
                    break;
                case (byte)Animation.IdleCheckoutLegs:
                    StartCoroutine("IdleCheckoutLegsRoutine");
                    break;
                case (byte)Animation.IdleTwist:
                    StartCoroutine("IdleTwistRoutine");
                    break;
            }
        }
        else
        {
            StartCoroutine("BasicIdleRoutine");
        }
    }

    //makes the character blink every few seconds
    IEnumerator BasicIdleRoutine()
    {
        bBaseIdleRoutine = true;
        while (bBaseIdleRoutine)
        {
            //wait for random amount of time
            yield return new WaitForSeconds(Random.Range(4f,11f));
            //close eyes
            mat_eyes.SetTextureOffset("_MainTex", new Vector2(.8f, 0));
            yield return new WaitForSeconds(.2f);
            //open eyes
            mat_eyes.SetTextureOffset("_MainTex", new Vector2(0, 0));
        }

    }

    IEnumerator IdleButtRoutine()
    {
        yield return new WaitForSeconds(1.75f);
        //close eyes
        mat_eyes.SetTextureOffset("_MainTex", new Vector2(.8f, 0));
        //closed mouth smile
        mat_mouth.SetTextureOffset("_MainTex", new Vector2(.8f, 0));
        //raise eyebrows
        mat_eyebrows.SetTextureOffset("_MainTex", new Vector2(.75f, 0));
        yield return new WaitForSeconds(1.4f);
        mat_eyes.SetTextureOffset("_MainTex", new Vector2(0, 0));
        mat_mouth.SetTextureOffset("_MainTex", new Vector2(0, 0));
        mat_eyebrows.SetTextureOffset("_MainTex", new Vector2(0, 0));
    }

    IEnumerator IdleCheckoutArmsRoutine()
    {
        yield return new WaitForSeconds(.2f);
        //close mouth
        mat_mouth.SetTextureOffset("_MainTex", new Vector2(.2f, 0));
        //blink 
        mat_eyes.SetTextureOffset("_MainTex", new Vector2(.8f, 0));
        yield return new WaitForSeconds(.2f);
        mat_eyes.SetTextureOffset("_MainTex", new Vector2(0, 0));
        yield return new WaitForSeconds(2.5f);
        //closed mouth smile
        mat_mouth.SetTextureOffset("_MainTex", new Vector2(.8f, 0));
        yield return new WaitForSeconds(1f);
        mat_mouth.SetTextureOffset("_MainTex", new Vector2(0, 0));

    }

    IEnumerator IdleCheckoutBackRoutine()
    {
        yield return new WaitForSeconds(.2f);
        //close mouth
        mat_mouth.SetTextureOffset("_MainTex", new Vector2(.2f, 0));
        //blink 
        mat_eyes.SetTextureOffset("_MainTex", new Vector2(.8f, 0));
        yield return new WaitForSeconds(.2f);
        mat_eyes.SetTextureOffset("_MainTex", new Vector2(0, 0));
        yield return new WaitForSeconds(1.3f);
        //closed mouth smile
        mat_mouth.SetTextureOffset("_MainTex", new Vector2(.8f, 0));
        yield return new WaitForSeconds(.4f);
        mat_mouth.SetTextureOffset("_MainTex", new Vector2(0, 0));
    }

    IEnumerator IdleCheckoutLegsRoutine()
    {
        yield return new WaitForSeconds(.2f);
        //close mouth
        mat_mouth.SetTextureOffset("_MainTex", new Vector2(.2f, 0));
        //blink 
        mat_eyes.SetTextureOffset("_MainTex", new Vector2(.8f, 0));
        yield return new WaitForSeconds(.2f);
        mat_eyes.SetTextureOffset("_MainTex", new Vector2(0, 0));
        yield return new WaitForSeconds(.5f);
        //open mouth PogChamp
        mat_mouth.SetTextureOffset("_MainTex", new Vector2(.6f, 0));
        //raise eyebrows
        mat_eyebrows.SetTextureOffset("_MainTex", new Vector2(.75f, 0));
        yield return new WaitForSeconds(.7f);
        //close mouth
        mat_mouth.SetTextureOffset("_MainTex", new Vector2(.2f, 0));
        //lower eyebrows
        mat_eyebrows.SetTextureOffset("_MainTex", new Vector2(0, 0));
        yield return new WaitForSeconds(.8f);
        //open mouth PogChamp
        mat_mouth.SetTextureOffset("_MainTex", new Vector2(.6f, 0));
        //raise eyebrows
        mat_eyebrows.SetTextureOffset("_MainTex", new Vector2(.75f, 0));
        yield return new WaitForSeconds(.4f);
        //close mouth
        mat_mouth.SetTextureOffset("_MainTex", new Vector2(.2f, 0));
        //lower eyebrows
        mat_eyebrows.SetTextureOffset("_MainTex", new Vector2(0, 0));
        yield return new WaitForSeconds(.2f);
        mat_mouth.SetTextureOffset("_MainTex", new Vector2(0, 0));
    }

    IEnumerator IdleTwistRoutine()
    {
        yield return new WaitForSeconds(.2f);
        //close mouth
        mat_mouth.SetTextureOffset("_MainTex", new Vector2(.2f, 0));
        yield return new WaitForSeconds(.5f);
        //close eyes
        mat_eyes.SetTextureOffset("_MainTex", new Vector2(.8f, 0));
        //lower eyebrows
        mat_eyebrows.SetTextureOffset("_MainTex", new Vector2(.25f, 0));
        yield return new WaitForSeconds(.7f);
        //open eyes
        mat_eyes.SetTextureOffset("_MainTex", new Vector2(0, 0));
        //raise eyebrows
        mat_eyebrows.SetTextureOffset("_MainTex", new Vector2(0, 0));
        yield return new WaitForSeconds(1f);
        //close eyes
        mat_eyes.SetTextureOffset("_MainTex", new Vector2(.8f, 0));
        //lower eyebrows
        mat_eyebrows.SetTextureOffset("_MainTex", new Vector2(.25f, 0));
        yield return new WaitForSeconds(.7f);
        //open eyes
        mat_eyes.SetTextureOffset("_MainTex", new Vector2(0, 0));
        //raise eyebrows
        mat_eyebrows.SetTextureOffset("_MainTex", new Vector2(0, 0));
        yield return new WaitForSeconds(.2f);
        //open mouth
        mat_mouth.SetTextureOffset("_MainTex", new Vector2(0, 0));
    }

    private void OnDestroy()
    {
        mat_mouth.SetTextureOffset("_MainTex", new Vector2(0, 0));
        mat_eyebrows.SetTextureOffset("_MainTex", new Vector2(0, 0));
        mat_eyes.SetTextureOffset("_MainTex", new Vector2(0, 0));
    }


}
