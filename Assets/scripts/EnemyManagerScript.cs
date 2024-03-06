using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManagerScript : MonoBehaviour
{
    GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("enemy");
        
    }

    // Update is called once per frame
    void Update()
    {
        int enemiesAlive = 0;
        for (int i = 0; i < enemies.Length; i++)
        {
            if (enemies[i] != null)
            {
                enemiesAlive++;
            }
        }

        if (enemiesAlive == 0)
        {
            SceneManager.LoadScene("Level Select");


        }
        
    }
}
