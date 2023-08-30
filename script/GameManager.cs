using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Animator fanAC;
    //public Animator fanAC2;
    void Start()
    {
        
    }

    public void FanControl(string status)
    {
        Debug.Log("Hit");
        if (status == "On")
        {
            if (fanAC.GetCurrentAnimatorStateInfo(0).IsName("Idle")){
                fanAC.SetTrigger(status);
                //fanAC2.SetTrigger(status);
            }
        }else if (status == "Off")
        {
            if (fanAC.GetCurrentAnimatorStateInfo(0).IsName("Anim"))
            {
                fanAC.SetTrigger(status);
                //fanAC2.SetTrigger(status);
            }
        }
    }
    
}
