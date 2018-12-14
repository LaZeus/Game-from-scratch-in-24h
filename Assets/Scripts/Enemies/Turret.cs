using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{

    [SerializeField]
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Attack", 1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Attack()
    {
        anim.SetTrigger("Attack");
    }
}
