using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayVariables : MonoBehaviour
{
    public GameObject[] flagObjects;
    public GameObject[] countObjects;
    public GameObject hpObjects;
    public GameObject mpObjects;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for ( int i = 0; i < flagObjects.Length; i++)
        {
            if (GlobalVariable.flags[i])
            {
                flagObjects[i].GetComponent<Text>().text = "frag" + i.ToString() + ":" + "true";
            }
            else
            {
                flagObjects[i].GetComponent<Text>().text = "frag" + i.ToString() + ":" + "false";
            }
        }

        for (int i = 0; i < countObjects.Length; i++)
        {
            countObjects[i].GetComponent<Text>().text = "count" + i.ToString() + ":" + GlobalVariable.itemCounts[i];  
        }

        hpObjects.GetComponent<Text>().text = "HP:" + GlobalVariable.HP;
        mpObjects.GetComponent<Text>().text = "MP:" + GlobalVariable.MP;
    }
}
