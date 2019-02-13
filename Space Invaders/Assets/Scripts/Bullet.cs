using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // tried using collision but didn't work, would delete whole thing, turns out trigger worked

    void OnTriggerEnter2D (Collider2D col) {
        Debug.Log("collision name = " + col.gameObject.tag);
        if (col.gameObject.tag == "Top"){
            Player.off_screen = true;
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "Enemy"){
            Player.off_screen = true;
            Destroy(this.gameObject);
            Destroy(col.gameObject);
        }
    }
}
