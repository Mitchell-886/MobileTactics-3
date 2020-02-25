using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{
    public GameObject battleSystem;

    static public GameObject Enemy;
    public GameObject Player;

    public Transform playerBattleStation;
	public Transform enemyBattleStation;

	Unit playerUnit;
	Unit enemyUnit;
    
	public Text dialogueText;

	public BattleHUD playerHUD;
	public BattleHUD enemyHUD;

	public BattleState state;

    // Start is called before the first frame update
    void Start()
    {

		state = BattleState.START;
		StartCoroutine(SetupBattle());
        battleSystem.gameObject.SetActive(true);
    }

    void Update()
    {
        
        if(playerUnit == null)
        {
            GameObject playerUnit = GameObject.FindGameObjectWithTag("Player");
        }
        if(enemyUnit == null)
        {
            GameObject enemyUnit = GameObject.FindGameObjectWithTag("LFighter");
        }
    }

	IEnumerator SetupBattle()
	{
        
		GameObject playerGO = Instantiate(playerUnit.GetComponent<Unit>().playerPrefab, playerBattleStation);
		playerUnit = playerGO.GetComponent<Unit>();

		GameObject enemyGO = Instantiate(enemyUnit.GetComponent<EnemyUnit>().enemyPrefab, enemyBattleStation);
		enemyUnit = enemyGO.GetComponent<Unit>();
        Debug.Log("IsThisThingOn");
		dialogueText.text = "Incoming " + Enemy.GetComponent<EnemyUnit>().unitName + " Get ready for attack...";

		playerHUD.SetHUD(playerUnit);
		enemyHUD.SetHUD(enemyUnit);

		yield return new WaitForSeconds(2f);

		state = BattleState.PLAYERTURN;
		PlayerTurn();
	}

	IEnumerator PlayerAttack()
	{
		bool isDead = Enemy.GetComponent<EnemyUnit>().TakeDamage(Unit.damage);

		enemyHUD.SetHP(EnemyUnit.currentHP);
		dialogueText.text = "The attack is successful!";

		yield return new WaitForSeconds(2f);

		if(isDead)
		{
			state = BattleState.WON;
			EndBattle();
		} else
		{
			state = BattleState.ENEMYTURN;
			StartCoroutine(EnemyTurn());
		}
	}

	IEnumerator EnemyTurn()
	{
		dialogueText.text = Enemy.GetComponent<EnemyUnit>().unitName + " attacks!";

		yield return new WaitForSeconds(1f);

		bool isDead = playerUnit.GetComponent<Unit>().TakeDamage(EnemyUnit.damage);

		playerHUD.SetHP(Unit.currentHP);

		yield return new WaitForSeconds(1f);

		if(isDead)
		{
			state = BattleState.LOST;
			EndBattle();
		} else
		{
			state = BattleState.PLAYERTURN;
			PlayerTurn();
		}

	}

	void EndBattle()
	{
		if(state == BattleState.WON)
		{
			dialogueText.text = "You won the battle!";
            battleSystem.gameObject.SetActive(false);
        } else if (state == BattleState.LOST)
		{
			dialogueText.text = "You were defeated.";
            battleSystem.gameObject.SetActive(false);
        }
	}

	void PlayerTurn()
	{
		dialogueText.text = "Choose an action:";
	}

	IEnumerator PlayerHeal()
	{
		playerUnit.GetComponent<Unit>().Heal(5);

		playerHUD.SetHP(Unit.currentHP);
		dialogueText.text = "You feel renewed strength!";

		yield return new WaitForSeconds(2f);

		state = BattleState.ENEMYTURN;
		StartCoroutine(EnemyTurn());
	}

	public void OnAttackButton()
	{
		if (state != BattleState.PLAYERTURN)
			return;

		StartCoroutine(PlayerAttack());
	}

	public void OnHealButton()
	{
		if (state != BattleState.PLAYERTURN)
			return;

		StartCoroutine(PlayerHeal());
	}

}
