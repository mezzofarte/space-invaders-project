using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject enemyBullet;

    // Update is called once per frame
    void Update()
    {
        if (isBottommostEnemy()){
            if (Random.Range(0, 1000) == 250){
                Shoot();
            }
        }
    }

    void Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(this.transform.position, -Vector2.up);
        Debug.DrawRay(this.transform.position, -Vector2.up*9001, Color.green, 0.1f);
    
        GameObject b = (GameObject)(Instantiate (enemyBullet, transform.position, Quaternion.identity));
        Physics2D.IgnoreCollision(b.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        b.GetComponent<Rigidbody2D>().AddForce(-transform.up * 200);
    }

    bool isBottommostEnemy()
    {
        Vector3 temp = this.transform.position;
        temp.y -= 0.6f;
        
        bool intersecting = Physics2D.OverlapCircle(temp, 0.1f);
        if (intersecting){
            return false;
        }
        else{
            return true;
        }
    }

    // private void OnDrawGizmos(){
    //     Vector3 temp = this.transform.position;
    //     temp.y -= 0.6f;

    //     Gizmos.color = Color.red;
    //     Gizmos.DrawWireSphere(temp, 0.1f);
    // }
}
