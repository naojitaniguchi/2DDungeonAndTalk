using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateByKey : MonoBehaviour
{
    public KeyCode keycode;
    public GameObject[] targets;
    public GameObject[] triggerObjects;
    GameObject nowTarget = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keycode))
        {
            for ( int i = 0; i < targets.Length; i ++)
            {
                if (triggerObjects[i] == nowTarget)
                {
                    targets[i].SetActive(true);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        nowTarget = collision.gameObject;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        nowTarget = null;
    }
}
