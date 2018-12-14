using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeecherHead : MonoBehaviour
{
    [SerializeField]
    private float sanityDrainRate = 20;

    private SanityUI sanity;

    private CharacterAnimations anim;
   
    private void OnEnable()
    {
        if (sanity == null)
            sanity = transform.parent.parent.parent.GetComponent<CharacterController2D>().sanitySlider.GetComponent<SanityUI>();

        if (anim == null)
            anim = transform.parent.parent.parent.GetComponent<CharacterAnimations>();

        Debug.Log("test");
        InvokeRepeating("SanityDrain", 1, 1);
    }

    private void SanityDrain()
    {
        sanity.InterpolateValue(sanityDrainRate);
        anim.TakeDamageAnimation();
    }

}
