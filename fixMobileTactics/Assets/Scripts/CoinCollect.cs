using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    public int coinCount = 0;
    public Text cointext;

    private void Start()
    {
        cointext.text = "Coins Amount: " + coinCount;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            coinCount++;
            cointext.text = "Coins Amount: " + coinCount;
            Destroy(collision.gameObject);
            
            if(coinCount > 15)
            {
                SceneManager.LoadScene(2);

            }
        }
    }
}
