using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemie_movment_bee : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;
    public bool MoveRight;

    Vector3 nextPos;

    void Start()
    {
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveRight)
        {
            transform.Translate(14 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(14, 14);

        }
        else
        {

            transform.Translate(-14 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-14, 14);
        }

        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
           if (MoveRight) {
            transform.Translate(14 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(14, 14);

        }
        else {
            
            transform.Translate(-14 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-14, 14);
        }
            
            if (MoveRight)
            {
                MoveRight = false;
            }
            else
            {
                MoveRight = true;
            }
        }
        if (transform.position == pos2.position)
        {
            nextPos = pos1.position;
            if (MoveRight)
            {
                MoveRight = false;
            }
            else
            {
                MoveRight = true;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
