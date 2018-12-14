using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class CharacterStats : MonoBehaviour
{
    [Header("Player's Stats")]

    [SerializeField]
    [Tooltip("Player's speed")]
    protected float MovementSpeed = 10f;

    [Header("Required Components")]

    [SerializeField]
    [Tooltip("Player's Rigidbody2D")]
    protected Rigidbody2D rb;

    [SerializeField]
    [Tooltip("The player's gameobject that contains the art")]
    protected Transform artParent;
}
