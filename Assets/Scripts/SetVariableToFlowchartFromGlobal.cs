using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVariableToFlowchartFromGlobal : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setCoinCount()
    {
        gameObject.GetComponent<Fungus.Flowchart>().SetIntegerVariable("CoinCount", GlobalVariable.itemCounts[(int)GlobalVariable.ITEM_TYPE.ITEM_00]);
    }
}
