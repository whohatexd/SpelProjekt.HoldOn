using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakeScript : MonoBehaviour
{
    public float timeleftAlive = 2.0f;
    public float expeForce = 100000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeleftAlive = Time.deltaTime;
        if (timeleftAlive <= 0)
        {
            explode();
            Destroy(gameObject);
        }
    }

    void explode()
    {
       var coliders= Physics2D.OverlapCircleAll(transform.position, 10);


        foreach (var colider in coliders)
        {
            if (colider.attachedRigidbody == null || colider.gameObject==gameObject)
            {
                continue;
            }
            var diff = (Vector2)colider.transform.position - (Vector2)transform.position;
            var expForce = diff.normalized * expeForce / diff.sqrMagnitude;
            colider.attachedRigidbody.AddForce(expForce, ForceMode2D.Impulse);
        }
    }
}
