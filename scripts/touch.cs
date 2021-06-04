using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{   private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Touch touch = Input.GetTouch(0);
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetMouseButton (0))
        {
            animator.SetBool("condicao", true);
        } 

        if ( Input.GetMouseButton (1))
        { 
            animator.SetBool("condicao", false);
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Handle finger movements based on TouchPhase
            switch (touch.phase)
            {
                //When a touch has first been detected, change the message and record the starting position
                case TouchPhase.Began:
                    // Record initial touch position.
                    animator.SetBool("condicao", true);
                    break;

                //Determine if the touch is a moving touch
                case TouchPhase.Moved:
                    // Determine direction by comparing the current touch position with the initial one
                    animator.SetBool("condicao", true);
                    break;

                case TouchPhase.Ended:
                    // Report that the touch has ended when it ends
                   animator.SetBool("condicao", false);
                    break;
            }
        }
        
    }
}
