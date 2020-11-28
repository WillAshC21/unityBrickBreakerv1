using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float moveSpeed;
    public Rigidbody2D rb;
    private AudioSource paddle;
    // Use this for initialization
    void Start()
    {
        paddle = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0 && Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0 && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
        }
    }
    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "Ball")
        {
            paddle.Play();
        }
    }
}
