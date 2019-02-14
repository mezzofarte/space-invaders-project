using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    private bool facingRight = true;

    // Update is called once per frame
    void Update()
    {
        if (!facingRight){
            this.transform.Translate(Vector3.left * speed * Time.deltaTime);    // Continuously move left
        }
        else if (facingRight){
            this.transform.Translate(Vector3.right * speed * Time.deltaTime);   // Continuously move right
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Invisible"))                               // This is for the invisible walls
        {
            // flip direction and go down
            this.transform.Translate(0.0f, -0.1f, 0.0f, Space.World);
            facingRight = !facingRight;
        }
        else if (col.collider.CompareTag("Bottom"))
        {
            Debug.Log("enemy reached bottom");
            // if reaches bottom, prompt game over
        }
    }
}
