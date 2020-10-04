using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItemCountByCollision : MonoBehaviour
{
    public GlobalVariable.ITEM_TYPE itemType;
    public float waitForDestory = 2.0f;
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
        if ( collision.gameObject.tag == "Player")
        {
            GlobalVariable.itemCounts[(int)itemType]++;

            if ( gameObject.GetComponent<AudioSource>() != null)
            {
                gameObject.GetComponent<AudioSource>().PlayOneShot(gameObject.GetComponent<AudioSource>().clip);
                StartCoroutine(destoryMySelf());
            }
            else
            {
                Destroy(gameObject);
            }
            
        }
    }

    IEnumerator destoryMySelf()
    {
        yield return new WaitForSeconds(waitForDestory);
        Destroy(gameObject);
    }

}
