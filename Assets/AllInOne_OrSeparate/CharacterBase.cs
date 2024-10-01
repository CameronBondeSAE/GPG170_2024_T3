using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Inherit from this class to get everything inside it
/// This also allows code to refer to object via this type. Avoiding lots of terrible hardcoded mess
/// </summary>
public class CharacterBase : MonoBehaviour
{
	public int level;
	public int health;

	public void Damage(int attackAmount)
	{
		Debug.Log(gameObject.name + " : GOT DAMAGE = "+attackAmount);
		health = health - attackAmount;
	}
}
