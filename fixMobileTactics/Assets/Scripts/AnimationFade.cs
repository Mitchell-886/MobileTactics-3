using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationFade : MonoBehaviour
{
    public Animator animator;
    private int LevelToLoad;

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Run")
        {
            SceneManager.LoadScene(2);
        }
    }
    public void FadeToLevel (int LevelIndex)
    {
        LevelToLoad = LevelIndex;
        animator.SetTrigger("Fade Out");
    }
    public void OnFadeComplete ()
    {
        SceneManager.LoadScene(LevelToLoad);
    }

}
