using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSanity : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The amount of sanity the player will lose")]
    private float amountOfSanity;

    // Start is called before the first frame update
    void Start()
    {
        if (amountOfSanity == 0)
        {
            amountOfSanity = 100;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            col.GetComponent<CharacterController2D>().sanitySlider.GetComponent<SanityUI>().InterpolateValue(amountOfSanity);
            col.GetComponent<CharacterAnimations>().TakeDamageAnimation();
        }
    }
}
