using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUnit : MonoBehaviour
{

	public string unitName;
	static public int unitLevel;

	static public int damage;

	static public int maxHP;
	static public int currentHP;

    
    public GameObject enemyPrefab;

    public GameObject battleSystem;

    void Start()
    {
        battleSystem.gameObject.SetActive(false);
    }

    public bool TakeDamage(int dmg)
	{
		currentHP -= dmg;

		if (currentHP <= 0)
			return true;
		else
			return false;
	}

	public void Heal(int amount)
	{
		currentHP += amount;
		if (currentHP > maxHP)
			currentHP = maxHP;
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            battleSystem.gameObject.SetActive(true);
            Debug.Log("combat");
        }
    }
}
