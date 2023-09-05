using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTransit : Transition
{
    void Update()
    {
        if(Target.PHealth <= 0)
        {
            NeedTransit = true;
        }
    }
}
