using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDemon : MonoBehaviour {
    public float speed = 5f;
	// Use this for initialization
	void Start ()
    {
        Invoke("AImove",2f); 
	}

    void AImove()
    {
        int dir = Random.Range(-1, 2);
        float speed = Random.Range(3f,8f);

        if (dir == 1)
        {
            transform.localScale = new Vector3(1, 1, 1);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        }
        else if (dir == -1)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
        }
        else
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

        Invoke("AImove", 5f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 9)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == 8)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
