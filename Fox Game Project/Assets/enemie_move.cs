using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemie_move : MonoBehaviour {

    public float speed;
    public bool MoveRight;

    // Update is called once per frame
    void Update() {

        if(MoveRight) {
            transform.Translate(14 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-14, 14);
            
        }
        else {
            transform.Translate(-14 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(14, 14);
        }

    }

    void OnTriggerEnter2D(Collider2D trig) {

        if (trig.gameObject.CompareTag("turn")) {

            if(MoveRight) {
                MoveRight = false;
            }
            else {
                MoveRight = true;
            }
        }


    }
}
