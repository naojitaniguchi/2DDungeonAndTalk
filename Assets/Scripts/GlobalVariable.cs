using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariable : MonoBehaviour
{
    public enum FLAG_TYPE
    {
        FLAG_00 = 0,
        FLAG_01 = 1,
        FLAG_02 = 2,
        FLAG_03 = 3,
        FLAG_04 = 4,
    };

    public enum ITEM_TYPE
    {
        ITEM_00 = 0,
        ITEM_01 = 1,
        ITEM_02 = 2,
        ITEM_03 = 3,
        ITEM_04 = 4,
    };

    public static bool[] flags;

    public static int[] itemCounts;
    public static int HP;
    public static int MP;

    // Start is called before the first frame update
    void Start()
    {
        flags = new bool[5];
        itemCounts = new int[5];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
