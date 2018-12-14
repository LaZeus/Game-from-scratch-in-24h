using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class CharacterStats : MonoBehaviour
{
    [Header("Player's Stats")]

    [SerializeField]
    [Tooltip("Player's speed")]
    protected float movementSpeed = 10f;

    [SerializeField]
    [Tooltip("Player's sanity value")]
    protected int sanity = 100;


    [Header("Required Components")]

    [SerializeField]
    [Tooltip("Player's Rigidbody2D")]
    protected Rigidbody2D rb;

    [SerializeField]
    [Tooltip("The player's gameobject that contains the art")]
    protected Transform artParent;


    [Header("References - Be sure to assign it on Start")]

    [SerializeField]
    [Tooltip("Reference to the sanity slider")]
    protected SanityUI sanitySlider;

}
