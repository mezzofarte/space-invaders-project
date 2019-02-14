using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // tried using collision but didn't work, would delete whole thing, turns out trigger worked
    void OnTriggerEnter2D (Collider2D col) {
        // Debug.Log("collision name = " + col.gameObject.tag);
        if (col.gameObject.tag == "Top"){
            Player.off_screen = true;
            Destroy(this.gameObject);
        }
        else if (col.gameObject.tag == "Enemy1"){
            Player.off_screen = true;
            ScoreManager.score += 10;
            Enemy.lives -= 1;
            Destroy(this.gameObject);
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "Enemy2"){
            Player.off_screen = true;
            ScoreManager.score += 20;
            Enemy.lives -= 1;
            Destroy(this.gameObject);
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "Enemy3"){
            Player.off_screen = true;
            ScoreManager.score += 40;
            Enemy.lives -= 1;
            Destroy(this.gameObject);
            Destroy(col.gameObject);
        }
        Debug.Log("Score: " + ScoreManager.score);
    }
}
