using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateByFlag : MonoBehaviour
{
    public GlobalVariable.ITEM_TYPE itemType;

    // Start is called before the first frame update
    void Start()
    {
        if (!GlobalVariable.items[(int)itemType]){
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
