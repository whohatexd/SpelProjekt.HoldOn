using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelButtonScript : MonoBehaviour
{
    public int nextlevel = 1;
    // Start is called before the first frame update
    void Start()
    {
        var tmpro = GetComponentInChildren<TextMeshProUGUI>();
        tmpro.text = nextlevel.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changelevel()
    {
        SceneManager.LoadScene("Level " + nextlevel);
    }
}
