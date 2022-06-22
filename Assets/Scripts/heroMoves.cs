 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroMoves : MonoBehaviour
{

    public Animator anim;

    void Update()
    {
        bool IsItGrounded = transform.Find("GroundCheck").GetComponent<GroundCheck>().isGrounded;

        if (IsItGrounded)
        {
            if (Input.GetMouseButtonDown(0))
            {
                anim.SetTrigger("OnClick");
            }
            else if (Input.GetMouseButtonUp(0))
            {
                anim.SetTrigger("OnLet");
            }
            else { anim.ResetTrigger("OnAir"); anim.SetTrigger("GroundTouch"); } 
        }
        if (!IsItGrounded)
        {
            anim.ResetTrigger("GroundTouch");
            anim.SetTrigger("OnAir");
        }
    }
}
