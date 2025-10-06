using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class RigidBodySleep : MonoBehaviour
{
    private int sleepCountDown = 4;
    private Rigidbody rigid;


    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        if (sleepCountDown > 0)
        {
            rigid.Sleep();
            sleepCountDown--;
        }
    }


    /*
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    */
}
