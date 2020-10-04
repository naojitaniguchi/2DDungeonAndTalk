using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateByFlag : MonoBehaviour
{
    public GlobalVariable.FLAG_TYPE flagType;

    // Start is called before the first frame update
    void Start()
    {
        if (!GlobalVariable.flags[(int)flagType]){
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
