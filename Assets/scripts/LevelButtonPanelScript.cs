using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButtonPanelScript : MonoBehaviour
{
    public int numberOFlevels = 5;
    public GameObject LevelButton;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= numberOFlevels; i++)
        {
           var newbutton= Instantiate(LevelButton, transform);
            var lbs = newbutton.GetComponent<LevelButtonScript>();
            lbs.nextlevel = i;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
