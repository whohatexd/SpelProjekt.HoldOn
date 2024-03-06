using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ParrotSpawnerScript : MonoBehaviour
{
  
    bool parrotDraggin = false;
    public float Force = 5;
    public float maxVelocity = 20;
    

    public GameObject[] shots;
    public int nextshot = 0;
    public GameObject ParrotLeftText;
    TextMeshProUGUI tmpro;
    // Start is called before the first frame update
    void Start()
    {
        tmpro = ParrotLeftText.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonUp(0) && parrotDraggin && nextshot < shots.Length)
        {

            parrotDraggin = false;
            
            

            
            GameObject Newparrot = Instantiate(shots[nextshot], transform.position, Quaternion.identity);
            Rigidbody2D rb = Newparrot.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(20, 0);

            Vector3 Mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Mousepos.z = 0;

            rb.velocity = (transform.position - Mousepos)*Force;
            if (rb.velocity.magnitude>maxVelocity)
            {
                rb.velocity = rb.velocity.normalized * maxVelocity;
            }
            nextshot++;
            tmpro.text = $"ParrotsLeft:{shots.Length-nextshot}";

        }
    }
    private void OnMouseDown()
    {
        if (nextshot < shots.Length)
        {
            parrotDraggin = true;
            
        }
        
    }
}
