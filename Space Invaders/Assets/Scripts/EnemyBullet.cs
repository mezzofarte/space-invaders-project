using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D col) {
        // Debug.Log("collision name = " + col.gameObject.tag);
        if (col.gameObject.tag == "Bottommost"){
            Destroy(this.gameObject);
        }
        else if (col.gameObject.tag == "Player"){
            Debug.Log("lives = " + Player.lives);
            Player.lives -= 1;
            Destroy(this.gameObject);
        }
    }
}
