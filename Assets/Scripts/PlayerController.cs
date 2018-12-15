using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isJump = false;
    public bool isRight = true;
    public GameObject fireballPrefab;
    public float speed;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            isRight = false;
            transform.localScale = new Vector3(-1, 1, 1);
            transform.position += new Vector3(-speed*Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            isRight = true;
            transform.localScale = new Vector3(1, 1, 1);
            transform.position += new Vector3(speed*Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyUp(KeyCode.Space) && !isJump)
        {
            isJump = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,10 );
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            if (isRight)
            {
                GameObject obj = Instantiate(fireballPrefab, this.transform.position, Quaternion.identity);
                obj.GetComponent<FireBall>().isRight = isRight;
                obj.transform.localScale = new Vector3(1, 1, 1);
                obj.GetComponent<FireBall>().Init();
            }
            else
            {
                GameObject obj = Instantiate(fireballPrefab, this.transform.position, Quaternion.identity);
                obj.GetComponent<FireBall>().isRight = isRight;
                obj.transform.localScale = new Vector3(-1, 1, 1);
                obj.GetComponent<FireBall>().Init();
            }
        }

    }

    /*
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.layer == 10)
        {
            Destroy(gameObject);
        }
    }*/
}
