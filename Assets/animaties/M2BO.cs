using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M2BO : MonoBehaviour
{
    private Animator animator; // Animator for animations

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        bool moving = false;
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * -3 * Time.deltaTime;
            moving = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -3 * Time.deltaTime;
            moving = true;
        }

        if (Input.GetKey(KeyCode.D))

        {
            transform.position += transform.right * 3 * Time.deltaTime;
            moving = true;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * 3 * Time.deltaTime;
            moving = true;
        }
        animator.SetFloat("speed", moving ? 1:0);

        float mouseXmovement = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, mouseXmovement * 5,  0));
    }
}
            
       
