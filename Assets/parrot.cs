using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parrot : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = -5;
    SpriteRenderer sr;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            sr.flipY = !sr.flipY;
        }
       
    }
    
}
