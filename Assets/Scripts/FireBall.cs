using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour {

    public bool isRight;
    public float speed = 3f;
    public bool setup = false;

    public void Init()
    {
        if (!isRight)
        {
            speed = -speed;
        }
        print(speed);
        setup = true;
    }

    void Update ()
    {
        if(setup)
            transform.position += new Vector3(speed*Time.deltaTime,0,0);
	}
}
