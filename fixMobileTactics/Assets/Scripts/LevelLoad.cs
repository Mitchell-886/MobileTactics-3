using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Level")
        {
            SceneManager.LoadScene("Win");
        }
        if (collision.gameObject.tag == "Load")
        {
            SceneManager.LoadScene(3);
        }

    }
}
