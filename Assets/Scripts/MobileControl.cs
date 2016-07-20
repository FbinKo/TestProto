using UnityEngine;
using System.Collections;

public class MobileControl : MonoBehaviour {

    public float acc = 10.0f;
    public float maxSpeed = 50.0f;
    public float deceleration = 7.5f;

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }

    /*void Update()
    {
        Vector2 dir = Vector2.zero;

        dir.x = Input.acceleration.x;
        dir.y = Input.acceleration.y;

        if (dir.sqrMagnitude > 1)
        {
            dir.Normalize();
        }

        dir *= Time.deltaTime;

        transform.Translate(dir * acc);
    }*/

    void FixedUpdate()
    {
        float h = Input.acceleration.x;// GetAxis("Horizontal");
        float v = Input.acceleration.y;// GetAxis("Vertical");
        Debug.Log(h + " " + v);

        if (h * rb2d.velocity.x < maxSpeed)
            rb2d.AddForce(Vector2.right * h * acc);

        if (Mathf.Abs (rb2d.velocity.x) > maxSpeed)
            rb2d.velocity = new Vector2(Mathf.Sign (rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

        if (v * rb2d.velocity.y < maxSpeed)
            rb2d.AddForce(Vector2.up * v * acc);

        if (Mathf.Abs(rb2d.velocity.y) > maxSpeed)
            rb2d.velocity = new Vector2(rb2d.velocity.x, Mathf.Sign(rb2d.velocity.y) * maxSpeed);
    }
}
