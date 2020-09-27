using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariable : MonoBehaviour
{
    public enum ITEM_TYPE
    {
        ITEM_00 = 0,
        ITEM_01 = 1,
        ITEM_02 = 2,
        ITEM_03 = 3,
        ITEM_04 = 4,
    };

    public static bool[] items;

    // Start is called before the first frame update
    void Start()
    {
        items = new bool[5];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
