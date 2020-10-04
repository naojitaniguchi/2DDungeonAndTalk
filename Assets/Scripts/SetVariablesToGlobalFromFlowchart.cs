using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVariablesToGlobalFromFlowchart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RodOn()
    {
        GlobalVariable.flags[0] = true;
    }

    public void RodOff()
    {
        GlobalVariable.flags[0] = false;
    }
}
