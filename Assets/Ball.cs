using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ball : MonoBehaviour {
    public Rigidbody2D rb;
    public float force;
    bool start = false;
    private AudioSource brick;
    private static int hits = 0;
    void Start()
    {
        brick = GetComponent<AudioSource>();
    }
    void Update() {
        if (Input.GetKeyUp(KeyCode.Space) && start == false) {
            transform.SetParent(null);
            rb.AddForce(new Vector2(force, force));
            start = true;
        }
    }
    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "Fall")
        {
            Lives.lives -= 1;
            Reset();
            StartCoroutine(Wait());
        }
        if (obj.gameObject.tag == "brick")
        {
            brick.Play();
            Destroy(obj.gameObject);
            Score.score += 10;
        }
        if (obj.gameObject.tag == "silverbrick")
        {
            brick.Play();
            if (++hits == 3)
            {
                hits = 0;
                Destroy(obj.gameObject);
                Score.score += 20;
            }
        }
    }
    void Reset()
    {
        transform.position = new Vector2(0, -2);
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
    }
}
