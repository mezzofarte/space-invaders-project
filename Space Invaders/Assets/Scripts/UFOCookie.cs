using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOCookie : MonoBehaviour
{
    public float speed = 3f;
    public bool facingRight;
    // Start is called before the first frame update
    void Start()
    {
        if (this.transform.position.x < 0)
        {
            facingRight = true;    
        }
        else 
        {
            facingRight = false;  
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!facingRight)
        {
            this.transform.Translate(Vector3.left * speed * Time.deltaTime);    // Continuously move left
        }
        else if (facingRight)
        {
            this.transform.Translate(Vector3.right * speed * Time.deltaTime);   // Continuously move right
        }
        if (this.transform.position.x < -15 || this.transform.position.x > 15)
        {
            Destroy(this.gameObject);
        }
    }
}