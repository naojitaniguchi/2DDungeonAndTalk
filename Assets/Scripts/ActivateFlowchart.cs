using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFlowchart : MonoBehaviour
{
    public float effectTime = 2.0f;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ActivateTarget");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ActivateTarget()
    {
        yield return new WaitForSeconds(effectTime);

        target.SetActive(true);
    }
}
