using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeAndSceneChange : MonoBehaviour
{
    public float fadeoutTime = 2.0f ;
    public string nextScene;
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
        if ( elaspedTime > fadeoutTime)
        {
            SceneManager.LoadScene(nextScene);
        }
        float alpha = elaspedTime / fadeoutTime;

        gameObject.GetComponent<Image>().color = new Color(baseColor.r, baseColor.g, baseColor.b, alpha);
    }
}
