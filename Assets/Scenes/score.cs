using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class player : MonoBehaviour
{
    public float speed, jumpSpeed;
    private Rigidbody2D rb;
    public Score cc;

    void start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    void upadate()
    {
        float moveinp=Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(moveinp, 0, 0) * speed * Time.deltaTime;
        if (Input.GetkeyDown(KeyCode.Space) && Math.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.compareTag("Destroy"))
        {
            cc.coincounter++;
            Destroy(other.gameObject);
        },. jbcxuf 
        
    }
}
