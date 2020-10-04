using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetValuesToGlobal : MonoBehaviour
{
    public bool[] flags;
    public int[] itemCounts;
    public int HP;
    public int MP;

    bool set = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( GlobalVariable.flags != null)
        {
            if ( !set)
            {
                setValues();
                set = true;
            }
        }
    }

    public void setValues()
    {
        for (int i = 0; i < flags.Length; i++)
        {
            GlobalVariable.flags[i] = flags[i];
        }

        for (int i = 0; i < itemCounts.Length; i++)
        {
            GlobalVariable.itemCounts[i] = itemCounts[i];
        }
        GlobalVariable.HP = HP;
        GlobalVariable.MP = MP;
    }
}
