using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//testing gitignore log

public class MoveCharacter : MonoBehaviour
{
 
    public Sprite foxRun;
    public Sprite foxRunBack;
    public Sprite foxIdle;
    public Sprite foxJump;

    public float speed = 10.0f;
    public float jumpSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        

        //when key is pressed
        if (Input.GetKey("d"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = foxRun;

            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = foxRunBack;

        }
        if (Input.GetKey(KeyCode.Space) )
        {
            pos.y += jumpSpeed * Time.deltaTime;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = foxJump;
        }

        //when key is released
        if (Input.GetKeyUp("d"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = foxIdle;
        }
        if (Input.GetKeyUp("a"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = foxIdle;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = foxIdle;
        }

        transform.position = pos;
    }

    private void onTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("hit");
    }

}
