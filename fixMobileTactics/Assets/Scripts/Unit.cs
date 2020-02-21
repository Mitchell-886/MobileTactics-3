using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

	public string unitName;
	public int unitLevel;

	public int damage;

	public int maxHP;
	public int currentHP;

    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public GameObject battleSystem;

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

    private void OnCollision2D(Collider2D collision)
    {
        if (gameObject.tag == "Player" && collision.gameObject.tag == "Enemy")
        {
            battleSystem.GameObject.SetActive(true);
        }
        if (gameObject.tag == "Enemy" && collision.gameObject.tag == "Player")
        {
            battleSystem.GameObject.SetActive(true);
        }
    }
}
