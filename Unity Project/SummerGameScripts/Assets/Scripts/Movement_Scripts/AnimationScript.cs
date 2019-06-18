using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public KeyCodeData Forward, Run;
    private Animator anim;
    public BoolData isGrabbing;
    public KeyCodeData Push_Keys;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

   
    

    private void FixedUpdate()
    {

        if (Forward.KeyHold() && isGrabbing.value && Push_Keys.KeyHold())
        {
            anim.SetTrigger("PushingBlock");
        }
        else if (Forward.KeyUp() && isGrabbing.value && Push_Keys.KeyHold())
        {
            anim.ResetTrigger("DoneGrabbing");
            anim.ResetTrigger("PushingBlock");
            anim.SetTrigger("BlockIdle");
        }
        else if (isGrabbing.value && Push_Keys.KeyDown())
        {
            anim.ResetTrigger("PushingBlock");
            anim.ResetTrigger("DoneGrabbing");
            anim.SetTrigger("GrabBlock");
           
        }
       else if (Push_Keys.KeyUp())
        {
            anim.ResetTrigger("PushingBlock");
            anim.SetTrigger("DoneGrabbing");
        }
        

        else if (Forward.KeyHold())
        {
            anim.ResetTrigger("Idle");
            if (Run.KeyHold())
            {
                anim.SetTrigger("Run");
                anim.ResetTrigger("Walk");
                
            }
            else
            {
                
                anim.ResetTrigger("Run");
                anim.SetTrigger("Walk");
            }
            
        }
        
        else
        {
           
            anim.ResetTrigger("Run");
            anim.ResetTrigger("Walk");
            anim.SetTrigger("Idle");
        }
        
    }
}
