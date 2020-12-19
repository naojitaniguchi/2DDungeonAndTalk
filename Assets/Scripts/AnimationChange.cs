using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChange : MonoBehaviour
{
    public float walkSpeed = 10.0f;

    Vector3 rightDirScale = new Vector3(1.0f, 1.0f, 1.0f);
    Vector3 leftDirScale = new Vector3(-1.0f, 1.0f, 1.0f);
    // Start is called before the first frame update

    Rigidbody2D rb2d = null;

    bool talking = false;

    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (talking)
        {
            return;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Animator>().SetBool("Walk", true);
            gameObject.transform.localScale = rightDirScale;
            if (rb2d != null)
            {
                rb2d.velocity = Vector2.right * walkSpeed;
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<Animator>().SetBool("Walk", true);
            gameObject.transform.localScale = leftDirScale;

            if (rb2d != null)
            {
                rb2d.velocity = Vector2.right * walkSpeed * -1.0f;
            }
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.GetComponent<Animator>().SetBool("Walk", true);

            if (rb2d != null)
            {
                rb2d.velocity = Vector2.up * walkSpeed;
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.GetComponent<Animator>().SetBool("Walk", true);

            if (rb2d != null)
            {
                rb2d.velocity = Vector2.up * walkSpeed * -1.0f;
            }
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("Walk", false);
            rb2d.velocity = Vector2.zero;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.GetComponent<Animator>().SetTrigger("Attack");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.GetComponent<Animator>().SetTrigger("Strike");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            gameObject.GetComponent<Animator>().SetTrigger("Cast");
        }
    }

    public void Walk()
    {
        gameObject.GetComponent<Animator>().SetBool("Walk", true);
    }

    public void Idle()
    {
        gameObject.GetComponent<Animator>().SetBool("Walk", false);
    }

    public void Attack()
    {
        gameObject.GetComponent<Animator>().SetTrigger("Attack");
    }

    public void Strike()
    {
        gameObject.GetComponent<Animator>().SetTrigger("Strike");
    }

    public void Cast()
    {
        gameObject.GetComponent<Animator>().SetTrigger("Cast");
    }

    public void talkStart()
    {
        talking = true;
    }

    public void talkStop()
    {
        talking = false;
    }
}
