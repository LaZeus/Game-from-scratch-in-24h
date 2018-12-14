using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leecher : MonoBehaviour
{ 
    [SerializeField]
    private Animator anim;

    [SerializeField]
    private float movementSpeed;

    [SerializeField]
    private Transform points;

    [SerializeField]
    private int nextPoint = 0;

    private void Start()
    {
        if (points == null)
            points = transform.parent.Find("Points");
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, points.GetChild(nextPoint).position, movementSpeed * Time.deltaTime);

        if (transform.position == points.GetChild(nextPoint).position)
        {
            nextPoint++;
            if (nextPoint >= points.childCount)
                nextPoint = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            col.transform.Find("MCHead");
        }
    }
}
