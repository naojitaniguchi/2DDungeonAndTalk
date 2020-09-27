using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItemByCollision : MonoBehaviour
{
    public GlobalVariable.ITEM_TYPE itemType;
    public GameObject flowchart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.tag == "Player"){
            GlobalVariable.items[(int)itemType] = true;
            if ( flowchart != null)
            {
                flowchart.SetActive(true);
            }
            Destroy(gameObject);
        }
    }
}
