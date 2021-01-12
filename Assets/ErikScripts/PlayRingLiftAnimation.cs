using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRingLiftAnimation : MonoBehaviour
{
    public Collider Sphere;
    public Animator RingLiftAnimation;


    private void Awake()
    {
        GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (Sphere == "Sphere")
        //{
        //Invoke("AnimStart", 1.5f);
        //     RingLiftAnimation.SetBool("PlayaAnimation", true);
        //}
        if (other == Sphere)
        {
            RingLiftAnimation.enabled = true;
            RingLiftAnimation.SetBool("PlayAnimation", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other == Sphere)
        {
            //RingLiftAnimation.enabled = true;
            RingLiftAnimation.SetBool("PlayAnimation", false);
        }
    }
    void Start()
    {
        
        RingLiftAnimation.SetBool("PlayAnimation", false);
    }

    void AnimStart()
    {
        //RingLiftAnimation.SetBool("PlayAnimation", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
