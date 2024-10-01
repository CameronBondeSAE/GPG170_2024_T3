using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameEverything : MonoBehaviour
{
	public int playerAttackAmount;
	public int goblinHealth;
// public TextMeshProUGUI
	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			PlayerAttack();
		}
	}

	// Defining a function
	public void PlayerAttack()
	{
		Debug.Log("Attack");
		goblinHealth = goblinHealth - 10;
	}

	public void GoblinGenerator()
	{
	
	}

}
