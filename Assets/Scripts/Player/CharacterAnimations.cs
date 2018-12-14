using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class CharacterAnimations : MonoBehaviour
{
    [SerializeField]
    private Animator anim;

    public float[] shakeValues;

    private CameraShake cam;


    private void Start()
    {
        if (cam == null)
            cam = GameObject.Find("MCamera").GetComponent<CameraShake>();
    }

    public void TakeDamageAnimation()
    {
        anim.SetTrigger("TookDamage");
        cam.ShakeCamera(shakeValues[0], shakeValues[1]);
    }
}
