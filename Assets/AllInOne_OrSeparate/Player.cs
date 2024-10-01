using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CharacterBase
{
	public int attackAmount;
	// Target ANY character that 'inherits' from this class
	public CharacterBase target;

	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Attack();
		}
	}

	public void Attack()
	{
		Debug.Log("Attack");
		// Damage ALL characters with one line of code
		target.Damage(attackAmount);
	}

	// Eg if this character was a rocket or killed things on touch
	private void OnCollisionEnter(Collision other)
	{
		// Using in inheritance we can now attack ANY character with no hardcoded knowledge of them
		other.gameObject.GetComponent<CharacterBase>().Damage(10000000);
	}
}
