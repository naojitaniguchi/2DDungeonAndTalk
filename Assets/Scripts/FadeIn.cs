using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public float fadeTime = 2.0f;
    float elaspedTime = 0;
    Color baseColor;

    // Start is called before the first frame update
    void Start()
    {
        baseColor = gameObject.GetComponent<Image>().color;
    }

    // Update is called once per frame
    void Update()
    {
        elaspedTime += Time.deltaTime;
        if (elaspedTime > fadeTime)
        {
            gameObject.SetActive(false);
        }
        float alpha = 1.0f - (elaspedTime / fadeTime);


        gameObject.GetComponent<Image>().color = new Color(baseColor.r, baseColor.g, baseColor.b, alpha);
    }
}
