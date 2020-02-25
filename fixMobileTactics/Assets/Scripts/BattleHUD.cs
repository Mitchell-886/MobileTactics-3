using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{

	public Text nameText;
	public Text levelText;
	public Slider hpSlider;

	public void SetHUD(Unit unit)
	{
		nameText.text = Unit.unitName;
		levelText.text = "Lvl " + Unit.unitLevel;
		hpSlider.maxValue = Unit.maxHP;
		hpSlider.value = Unit.currentHP;
	}

	public void SetHP(int hp)
	{
		hpSlider.value = hp;
	}

}
