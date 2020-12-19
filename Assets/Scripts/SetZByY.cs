using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetZByY : MonoBehaviour
{
    public float yRange = 5.0f;
    public float zRange = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float z = (gameObject.transform.position.y / yRange) * zRange;
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,z);
    }
}
